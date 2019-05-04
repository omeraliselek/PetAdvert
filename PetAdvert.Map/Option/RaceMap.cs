using PetAdvert.Core.Map;
using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Map.Option
{
    public class RaceMap:CoreMap<Race>
    {
        public RaceMap()
        {
            ToTable("db.Races");

            Property(x => x.RaceName).HasMaxLength(120).IsOptional();
            Property(x => x.SeoTitle).HasMaxLength(72).IsOptional();
            Property(x => x.SeoDescription).HasMaxLength(172).IsOptional();

            HasRequired(x => x.Pettype)
                .WithMany(x => x.Races)
                .HasForeignKey(x => x.PettypeID)
                .WillCascadeOnDelete(true);//katerorisi silinirse ürün silinsin

            HasMany(x => x.Advertisements)//Birden fazla ürünü olacaktır.
                .WithRequired(x => x.Race)//Bir ürünün bir kategorisi olur.
                .HasForeignKey(x => x.RaceID);

        }
    }
}

