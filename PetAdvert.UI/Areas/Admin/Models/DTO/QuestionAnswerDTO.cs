using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.DTO
{
    public class QuestionAnswerDTO : BaseDTO
    {
        public string Question { get; set; }
        public string Reply { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
    }
}