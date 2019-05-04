using PetAdvert.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Model.Option
{
   public class District: CoreEntity, ISeo
    {
        //İlçeler

        public string Ilce { get; set; }

        public int CityID { get; set; }
        public virtual City City { get; set; }
        public virtual List<Advertisement> Advertisements { get; set; }
        public string SeoTitle { get; set ; }
        public string SeoDescription { get ; set; }
    }
}
