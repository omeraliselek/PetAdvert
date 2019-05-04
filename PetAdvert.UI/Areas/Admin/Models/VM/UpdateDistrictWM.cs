using PetAdvert.Model.Option;
using PetAdvert.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.VM
{
    public class UpdateDistrictWM:BaseVM
    {
        public UpdateDistrictWM()
        {
            Cities = new List<City>();
            districtDTO = new DistrictDTO();
        }
        public List<City> Cities { get; set; }
        public DistrictDTO districtDTO { get; set; }
    }
}