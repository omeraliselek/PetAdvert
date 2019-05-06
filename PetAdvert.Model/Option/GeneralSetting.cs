using PetAdvert.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Model.Option
{
   public class GeneralSetting: CoreEntity, ISeo
    {
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string instagram { get; set; }
        public string Pinterest { get; set; }
        public string Youtube { get; set; }
        public string CopyrightText { get; set; }
        public string Googleplay { get; set; }
        public string AppStore { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
    }
    }

