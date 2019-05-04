using PetAdvert.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Model.Option
{
  //Mesajlaşma
   public class Message: CoreEntity
    {
        public string Subject { get; set; }
        public int AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
