using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.DTO
{
    public class DistrictDTO : BaseDTO
    {
        public string Ilce { get; set; }
        public Guid CityID { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
    }
}