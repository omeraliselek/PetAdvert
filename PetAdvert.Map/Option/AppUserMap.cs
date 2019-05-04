using PetAdvert.Core.Map;
using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Map.Option
{
    public class AppUserMap:CoreMap<AppUser>
    {
        public AppUserMap()
        {
            Property(x => x.UserName).HasMaxLength(50).IsRequired();
            Property(x => x.Password).HasMaxLength(50).IsRequired();
            Property(x => x.PhoneNumber).HasMaxLength(50).IsRequired();
            Property(x => x.OtherPhone).HasMaxLength(50).IsRequired();
            Property(x => x.Role).IsOptional();
            Property(x => x.FirstName).HasMaxLength(50).IsOptional();
            Property(x => x.LastName).HasMaxLength(50).IsOptional();
            Property(x => x.Email).HasMaxLength(90).IsOptional();
            Property(x => x.Address).HasMaxLength(150).IsOptional();
            Property(x => x.Birthdate).HasColumnType("datetime2").IsOptional();
            Property(x => x.Biography).HasMaxLength(150).IsOptional();
            Property(x => x.job).HasMaxLength(60).IsOptional();
            Property(x => x.UserImage).IsOptional();
            Property(x => x.XSmallUserImage).IsOptional();
            Property(x => x.CruptedUserImage).IsOptional();

            HasMany(x => x.Advertisements)//Birden fazla ürünü olacaktır.
                .WithRequired(x => x.AppUser)//Bir ürünün bir kategorisi olur.
                .HasForeignKey(x => x.AppUserID);


            HasMany(x => x.Messages)//Birden fazla ürünü olacaktır.
                .WithRequired(x => x.AppUser)//Bir ürünün bir kategorisi olur.
                .HasForeignKey(x => x.AppUserID);

        }
    }
}
