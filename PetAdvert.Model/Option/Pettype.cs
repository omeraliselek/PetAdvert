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
        public int PettypeName { get; set; }
        public int PettypeDescription { get; set; }
        public int RaceID { get; set; }
        public virtual Race Race { get; set; }

        public string SeoTitle { get ; set ; }
        public string SeoDescription { get ; set; }
    }
}
