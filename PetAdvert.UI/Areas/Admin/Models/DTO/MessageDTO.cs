using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.DTO
{
    public class MessageDTO : BaseDTO
    {
        public string Subject { get; set; }
        public Guid AppUserID { get; set; }
        
    }
}