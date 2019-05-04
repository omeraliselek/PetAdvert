using PetAdvert.Core.Map;
using PetAdvert.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.Map.Option
{
    public class QuestionAnswerMap:CoreMap<QuestionAnswer>
    {
        public QuestionAnswerMap()
        {
            ToTable("d.QuestionAnswers");
            Property(x => x.Question).HasMaxLength(140).IsOptional();
            Property(x => x.Reply).HasMaxLength(500).IsOptional();
            Property(x => x.SeoTitle).HasMaxLength(72).IsOptional();
            Property(x => x.SeoDescription).HasMaxLength(172).IsOptional();


        }
    }
}
