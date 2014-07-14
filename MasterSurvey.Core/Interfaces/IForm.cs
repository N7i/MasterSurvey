using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Core.Interfaces
{
    public interface IForm
    {
        String Title { get; set; }
        DateTime CreatedAt { get; }

        IQuestion Questions { get; }

        IReadOnlyDictionary<String, IFormAnswer> Answers { get; }

        IFormAnswer FindOrCreateAnswerFor(String entity);
    }
}
