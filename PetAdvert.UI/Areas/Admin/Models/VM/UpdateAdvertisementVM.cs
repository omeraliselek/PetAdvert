using PetAdvert.Model.Option;
using PetAdvert.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.VM
{
    public class UpdateAdvertisementVM:BaseVM
    {
        public UpdateAdvertisementVM()
        {
            appUsers = new List<AppUser>();
            Cities = new List<City>();
            Districts = new List<District>();
            Pettypes = new List<Pettype>();
            Races = new List<Race>();
            advertisements = new AdvertisementDTO();
        }

        public List<AppUser> appUsers { get; set; }
        public List<City> Cities { get; set; }
        public List<District> Districts { get; set; }
        public List<Pettype> Pettypes { get; set; }
        public List<Race> Races { get; set; }
        public AdvertisementDTO advertisements { get; set; }
        
    }
}
    
