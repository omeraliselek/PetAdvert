using PetAdvert.Core.Enum;
using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.DTO
{
    public class AdvertisementDTO:BaseDTO
    {
        public string AdTitle { get; set; }
        public Adtype adtype { get; set; } 
        public Gender gender { get; set; }
        public Role role { get; set; }
        public Byte Age { get; set; }
        public string Detail { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public Guid DistrictID { get; set; }
        public Guid AppUserID { get; set; }
        public Guid RaceID { get; set; }
       
    }
}