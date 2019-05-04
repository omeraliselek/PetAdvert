using PetAdvert.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Model.Option
{
    public class Race : CoreEntity, ISeo
    {
        public string RaceName { get; set; }
        public string SeoTitle { get; set ; }
        public string SeoDescription { get; set; }
        public virtual List<Pettype> Pettypes { get; set; }
        public int AdvertisementID { get; set; }
        public virtual Advertisement Advertisement { get; set; }

    }
}
