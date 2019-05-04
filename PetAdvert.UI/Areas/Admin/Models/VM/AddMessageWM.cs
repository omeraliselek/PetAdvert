using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.VM
{
    public class AddMessageWM:BaseVM
    {
        public AddMessageWM()
        {
            appUsers = new List<AppUser>();
            messages = new List<Message>();
        }

        public List<AppUser> appUsers { get; set; }
        public List<Message> messages { get; set; }
    }
}