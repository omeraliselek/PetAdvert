using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.VM
{
    public class AddRaceWM:BaseVM
    {
        public AddRaceWM()
        {
            Pettypes = new List<Pettype>();
            Races = new List<Race>();
        }
        public List<Pettype> Pettypes { get; set; }
        public List<Race> Races { get; set; }
    }
}