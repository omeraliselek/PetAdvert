using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.DTO
{
    public class PettypeDTO : BaseDTO
    {
        public string PettypeName { get; set; }
        public string PettypeDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
    }
}