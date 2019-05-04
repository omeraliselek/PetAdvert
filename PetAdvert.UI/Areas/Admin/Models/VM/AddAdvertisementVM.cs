using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.VM
{
    public class AddAdvertisementVM:BaseVM
    {
        public AddAdvertisementVM()
        {
            appUsers = new List<AppUser>();
            Cities = new List<City>();
            Districts = new List<District>();
            Pettypes = new List<Pettype>();
            Races = new List<Race>();
            advertisements = new List<Advertisement>();
        }

        public List<AppUser> appUsers { get; set; }
        public List<City> Cities { get; set; }
        public List<District> Districts { get; set; }
        public List<Pettype> Pettypes { get; set; }
        public List<Race> Races { get; set; }
        public List<Advertisement> advertisements { get; set; }
    }
}