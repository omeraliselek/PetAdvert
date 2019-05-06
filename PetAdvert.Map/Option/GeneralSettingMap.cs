using PetAdvert.Core.Map;
using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Map.Option
{
    public class GeneralSettingMap : CoreMap<GeneralSetting>
    {
        public GeneralSettingMap()
        {
            ToTable("db.GeneralSettings");
            Property(x => x.Email).HasMaxLength(150).IsOptional();
            Property(x => x.Telephone).HasMaxLength(11).IsOptional();
            Property(x => x.Facebook).HasMaxLength(150).IsOptional();
            Property(x => x.Twitter).HasMaxLength(150).IsOptional();
            Property(x => x.instagram).HasMaxLength(150).IsOptional();
            Property(x => x.Pinterest).HasMaxLength(150).IsOptional();
            Property(x => x.Youtube).HasMaxLength(150).IsOptional();
            Property(x => x.CopyrightText).HasMaxLength(180).IsOptional();
            Property(x => x.Googleplay).HasMaxLength(150).IsOptional();
            Property(x => x.AppStore).HasMaxLength(150).IsOptional();
            Property(x => x.SeoTitle).HasMaxLength(150).IsOptional();
            Property(x => x.SeoDescription).HasMaxLength(180).IsOptional();






        }
    }
        }
    
