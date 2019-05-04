using PetAdvert.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Model.Option
{
    //İller
    public class City: CoreEntity,ISeo
    {
        public string Il { get; set; }
        public virtual List<District> Districts { get; set; }
        public string SeoTitle { get { return SeoTitle; } set { SeoTitle = value; } }
        public string SeoDescription { get { return SeoDescription; } set {SeoDescription= value; } }
    }
}
