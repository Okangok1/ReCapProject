using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarNameInvalidUpdate= "Araba ismi geçersiz veya önceki ismi ile aynı";
        public static string CarDeletionFailed = "Silme İslemi başarısız oldu";
        public static string BrandNameInvalid = " Brand  name ismi geçersiz";
        public static string BrandAdded = "marka eklendi";
        public static string BrandDeletedFailed = "silme islemi başarısız";
        public static string BrandDeleted = "Silme islemi başarılı";
        public static string BrandUpdated = " Marka güncellendi";
        public static string BrandUpdatedFailed = "marka güncelleme islemi başarısız oldu";
        public static string ColorAdded = "renk eklendi";
        public static string ColorNameInvalid = "renk ismi geçersiz";
        internal static string ColorDeletedfailed;
        internal static string ColorDeleted;
        internal static string ColorUpdatedFailed;
        internal static string ColorUpdated;
    }
}
