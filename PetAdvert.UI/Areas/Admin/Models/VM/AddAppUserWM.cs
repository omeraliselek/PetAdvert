using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.VM
{
    public class AddAppUserWM:BaseVM
    {
        public AddAppUserWM()
        {
            appUsers = new List<AppUser>();
            Cities = new List<City>();
            Districts = new List<District>();
        }

        public List<AppUser> appUsers { get; set; }
        public List<City> Cities { get; set; }
        public List<District> Districts { get; set; }
    }
}