﻿using IEntities.Concrete;
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
        public static string ColorDeletedfailed= "renk silme islemi basarısız oldu";
        public static string ColorDeleted="Renk silindi";
        public static string ColorUpdatedFailed="Renk güncelleme başarısız oldu";
        public static string ColorUpdated="Renk güncellendi";
        internal static string RentalAdded="eklendi";
        internal static string RentalDeleted;
        internal static string RentalUpdated;
        internal static string RentalUpdatedInvalid;
        internal static string UserAdded;
        internal static string UserDeleted;
        internal static string UserUpdatedInvalid;
        internal static string UserUpdate;
        internal static string CustemerCompanyNameInvalid;
        internal static string CustomerUpdated;
        internal static string CustomerAdded;
        internal static string CustomerDeleted;
    }
}
