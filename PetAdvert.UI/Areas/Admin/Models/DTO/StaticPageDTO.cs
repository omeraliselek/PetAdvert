using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.DTO
{
    public class StaticPageDTO : BaseDTO
    {
        public string PageName { get; set; }
        public string Detail { get; set; }
        public string SeoTitle { get { return SeoTitle; } set { SeoTitle = value; } }
        public string SeoDescription { get { return SeoDescription; } set { SeoDescription = value; } }
    }
}