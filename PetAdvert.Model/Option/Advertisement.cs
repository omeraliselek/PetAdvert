using PetAdvert.Core.Entity;
using PetAdvert.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Model.Option
{
     //İlanlar
    public class Advertisement : CoreEntity, ISeo
    {
        public string AdTitle { get; set; }
        public Adtype adtype{ get; set; } //İlanTürü
        public Gender gender { get; set; }
        public Role role { get; set; }
        public Byte Age { get; set; }
        public  string Detail { get; set; }
        public string SeoTitle { get; set ; }
        public string SeoDescription { get; set; }
        public Guid DistrictID { get; set; }
        public virtual District District { get; set; }
        public Guid AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }
        public Guid RaceID { get; set; }
        public virtual Race Race { get; set; }
        

    }
}
