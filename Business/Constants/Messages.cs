using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {

        // System Messages
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string AuthorizationDenied = "Yetkiniz Yok";
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
        public static string UserRegistered = "Kullanıcı Kayıt Edildi";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Zaten Var";
        public static string AccessTokenCreated = "Erişim Tokeni Oluşturuldu";
        // End of Product Messages

        // Category Manager Messages 
        //
        // End of Category Manager Messages
    }
}
