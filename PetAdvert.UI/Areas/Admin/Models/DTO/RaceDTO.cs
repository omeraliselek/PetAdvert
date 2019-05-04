using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.DTO
{
    public class RaceDTO : BaseDTO
    {
        public string RaceName { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public Guid PettypeID { get; set; }
        
        
    }
}