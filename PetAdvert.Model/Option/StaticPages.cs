using PetAdvert.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Model.Option
{
     //Statik Sayfalar

    public class StaticPages:CoreEntity,ISeo
    {
        public string PageName { get ; set; }
        public string Detail { get; set; }
        public string SeoTitle { get { return SeoTitle; } set { SeoTitle = value; } }
        public string SeoDescription { get { return SeoDescription; } set { SeoDescription = value; } }
    }
}
