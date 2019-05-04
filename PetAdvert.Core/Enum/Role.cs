using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Core.Enum
{
   public enum Role
    {
        None = 0,
        Admin = 1, // Yönetici
        Editor = 3,  // Editör  Sadece İlan Onaylama Yetkisi
        Author = 4,  // Sadece Yazı Ekleme yetkisi
        Member =5, //ilan Ekleme ve ilanları görme yetkisi

    }
}
