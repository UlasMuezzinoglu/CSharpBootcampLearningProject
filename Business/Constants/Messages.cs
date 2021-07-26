using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {

        // System Messages
        public static string MaintenanceTime = "Sistem Bakımda";
        // End of System Messages

        // Product Manager Messages
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductDoesntAdded = "Ürün Eklenemedi";
        public static string ProductNameInvalid = "Ürün ismi eçersiz";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductsListedByCategoryId = "Ürün Kategoriye Göre Listelendi";
        public static string ProductListedById = "Ürün ID ye Göre Listelendi";
        public static string ProductsListedByUnitPrice = "Ürün Birim Fiyatına Göre Listelendi";
        public static string ProductDoesNotExisting = "Böyle Bir Ürün Yok";
        public static string ProductIsExisting = "Ürün var";
        public static string CategoryOverflowError = "Ürün Eklenemedi... Kategoride ki Maksimum Ürün Sayısına Ulaşıldı";
        public static string SameNameError = "Bu ürün adı zaten kullanılıyor.";
        public static string CategoryLimitExceded = "Kategori Sayısı 15 den fazla iken ürün eklenemez.";
        // End of Product Messages

        // Category Manager Messages 
        //
        // End of Category Manager Messages
    }
}
