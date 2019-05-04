using PetAdvert.Core.Map;
using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Map.Option
{
    public class StaticPageMap:CoreMap<StaticPage>
    {
        public StaticPageMap()
        {
            ToTable("db.StaticPages");

            Property(x => x.PageName).HasMaxLength(72).IsOptional();
            Property(x => x.Detail).HasMaxLength(500).IsOptional();
            Property(x => x.SeoTitle).HasMaxLength(72).IsOptional();
            Property(x => x.SeoDescription).HasMaxLength(172).IsOptional();
        }
    }
}

