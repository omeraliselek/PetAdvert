using PetAdvert.Model.Option;
using PetAdvert.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.VM
{
    public class UpdateAppUserWM
    {
        public UpdateAppUserWM()
        {
            
            Cities = new List<City>();
            Districts = new List<District>();
            appUserDTO = new AppUserDTO();
        }

        public List<City> Cities { get; set; }
        public List<District> Districts { get; set; }
        public AppUserDTO appUserDTO { get; set; }
    }
}