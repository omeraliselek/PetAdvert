using PetAdvert.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Model.Option
{
    //Soru Cevap 

    public class QuestionAnswer : CoreEntity, ISeo
    {
        public string Question { get; set; }
        public string Reply { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
    }
}
