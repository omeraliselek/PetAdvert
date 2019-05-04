using PetAdvert.Core.Map;
using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Map.Option
{
    public class DistrictMap:CoreMap<District>
    {
        public DistrictMap()
        {
            ToTable("db.Districts");

            Property(x => x.Ilce).HasMaxLength(45).IsOptional();
            Property(x => x.SeoTitle).HasMaxLength(72).IsOptional();
            Property(x => x.SeoDescription).HasMaxLength(172).IsOptional();

            HasRequired(x => x.City)
                .WithMany(x => x.Districts)
                .HasForeignKey(x => x.CityID)
                .WillCascadeOnDelete(true);//katerorisi silinirse ürün silinsin

            HasMany(x => x.Advertisements)//Birden fazla ürünü olacaktır.
                .WithRequired(x => x.District)//Bir ürünün bir kategorisi olur.
                .HasForeignKey(x => x.DistrictID);

        }
    }
}
