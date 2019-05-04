using PetAdvert.Core.Map;
using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Map.Option
{
    public class MessageMap: CoreMap<Message>
    {
        public MessageMap()
        {
            Property(x => x.Subject).HasMaxLength(300).IsOptional();

            HasRequired(x => x.AppUser)
               .WithMany(x => x.Messages)
               .HasForeignKey(x => x.AppUserID)
               .WillCascadeOnDelete(true);//katerorisi silinirse ürün silinsin
        }
    }
}
