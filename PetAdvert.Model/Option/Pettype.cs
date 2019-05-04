using PetAdvert.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Model.Option
{    //PetTürü
    public class Pettype : CoreEntity, ISeo
    {
        public string PettypeName { get; set; }
        public string PettypeDescription { get; set; }
        public virtual List<Race> Races { get; set; }
        public string SeoTitle { get ; set ; }
        public string SeoDescription { get ; set; }
    }
}
