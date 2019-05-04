using PetAdvert.Core.Map;
using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Map.Option
{
    public class CityMap:CoreMap<City>
    {
        public CityMap()
        {
            ToTable("db.Cities");

            Property(x => x.Il).HasMaxLength(60).IsRequired();
            Property(x => x.SeoTitle).HasMaxLength(72).IsOptional();
            Property(x => x.SeoDescription).HasMaxLength(172).IsOptional();

            HasMany(x => x.Districts)//Birden fazla ürünü olacaktır.
                .WithRequired(x => x.City)//Bir ürünün bir kategorisi olur.
                .HasForeignKey(x => x.CityID);

        }
    }
}
