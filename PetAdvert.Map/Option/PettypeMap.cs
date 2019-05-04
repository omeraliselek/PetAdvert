using PetAdvert.Core.Map;
using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Map.Option
{
    public class PettypeMap:CoreMap<Pettype>
    {
        public PettypeMap()
        {
            ToTable("db.Pettypes");
            Property(x => x.PettypeName).HasMaxLength(60).IsOptional();
            Property(x => x.PettypeDescription).HasMaxLength(172).IsOptional();
            Property(x => x.SeoTitle).HasMaxLength(72).IsOptional();
            Property(x => x.SeoDescription).HasMaxLength(172).IsOptional();

            HasMany(x => x.Races)//Birden fazla ürünü olacaktır.
                   .WithRequired(x => x.Pettype)//Bir ürünün bir kategorisi olur.
                   .HasForeignKey(x => x.PettypeID);

        }
    }
}
