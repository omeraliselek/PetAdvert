using PetAdvert.Core.Enum;
using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdvert.UI.Areas.Admin.Models.DTO
{
    public class AppUserDTO : BaseDTO
    {
        public string UserName { get; set; }  //Kullanıcı Adı
        public string Password { get; set; } //Şifresi
        public string PhoneNumber { get; set; } //TelefonNumarasi
        public string OtherPhone { get; set; }
        public Role Role { get; set; }  //Rolu
        public string FirstName { get; set; }  //Adı
        public string LastName { get; set; } //Soyadı
        public string Email { get; set; }  //E-posta adresi
        public string Address { get; set; } //Adress
        public DateTime? Birthdate { get; set; } //Doğum Tarihi
        public string Biography { get; set; } // Biyogafi
        public string job { get; set; }  //Meslek
        public string UserImage { get; set; }  //Kulllanıcının resmi
        public string XSmallUserImage { get; set; }
        public string CruptedUserImage { get; set; }
        
        
     
    }
}