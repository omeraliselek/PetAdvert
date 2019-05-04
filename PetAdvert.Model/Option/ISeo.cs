using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Model.Option
{   //SeoAyarları
    public interface ISeo
    {
        string SeoTitle { get; set; }
       string SeoDescription { get; set; }
    }
}
