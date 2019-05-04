using PetAdvert.Core.Map;
using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Map.Option
{
    public class AdvertisementMap:CoreMap<Advertisement>
    {

        public AdvertisementMap()
        {
            ToTable("db.Advertisements");
            Property(x => x.AdTitle).HasMaxLength(150).IsOptional();
            Property(x => x.adtype).IsOptional();
            Property(x => x.gender).IsOptional();
            Property(x => x.role).IsOptional();
            Property(x => x.Age).IsOptional();
            Property(x => x.Detail).HasMaxLength(500).IsOptional();
            Property(x => x.SeoTitle).HasMaxLength(72).IsOptional();
            Property(x => x.SeoDescription).HasMaxLength(172).IsOptional();

            HasRequired(x => x.District)
               .WithMany(x => x.Advertisements)
               .HasForeignKey(x => x.DistrictID)
               .WillCascadeOnDelete(true);//katerorisi silinirse ürün silinsin

            HasRequired(x => x.AppUser)
               .WithMany(x => x.Advertisements)
               .HasForeignKey(x => x.AppUserID)
               .WillCascadeOnDelete(true);//katerorisi silinirse ürün silinsin

            HasRequired(x => x.Race)
                .WithMany(x => x.Advertisements)
                .HasForeignKey(x => x.RaceID)
                .WillCascadeOnDelete(true);//katerorisi silinirse ürün silinsin
        }
    }
}