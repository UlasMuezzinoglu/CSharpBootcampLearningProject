using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        IProductDal _productDal;
        ILogger _logger;
        ICategoryService _categoryService;

        public ProductManager(IProductDal productDal, ILogger logger, ICategoryService categoryService)
        {
            _productDal = productDal;
            _logger = logger;
            _categoryService = categoryService;
        }
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            IResult result = BusinessRules.Run(
                IsOverflowCategory(product.CategoryId),
                IsThatNameExists(product.ProductName),
                IsOverflowCategoryCount()
                );
            if (result !=null)
            {
                return result;
            }

            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);



        }

        public IDataResult<List<Product>> GetAll()
        {
            // iş kodları
            // Yetkisi Var mı ?
            // Tüm Kontroller Bitti mi ?


            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
            //return new ErrorDataResult<List<Product>>("Ürün Yok...");

        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id), Messages.ProductsListedByCategoryId);
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == id), Messages.ProductListedById);
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max), Messages.ProductsListedByUnitPrice);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            if (DateTime.Now.Hour == 03)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(), Messages.ProductsListed);
        }

        //private bool IsThatExisting(int id)
        //{
        //    var result = _productDal.Get(p => p.ProductId == id);
        //    if (result == null)
        //    {
        //        return false;
        //    }
        //    return true;
        //}




        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product product)
        {

            _productDal.Add(product);
            return new Result(true, Messages.ProductAdded);
        }





        public IResult Delete(Product product)
        {
            throw new NotImplementedException();
        }
        private IResult IsOverflowCategory(int categoryId)
        {
            var result = _productDal.GetAll(p => p.CategoryId == categoryId);
            if (result.Count >= 15)
            {
                return new ErrorResult(Messages.CategoryOverflowError);
            }
            return new SuccessResult();
        }
        private IResult IsThatNameExists(string productName)
        {
            var result = _productDal.GetAll(p => p.ProductName == productName).Any();
            if (result)
            {
                return new ErrorResult(Messages.SameNameError);
            }
            return new SuccessResult();
        }
        private IResult IsOverflowCategoryCount()
        {
            var result = _categoryService.GetAll();

            if (result.Data.Count > 7)
            {
                return new ErrorResult(Messages.CategoryLimitExceded);
            }
            return new SuccessResult();
        }
         
    }
}
