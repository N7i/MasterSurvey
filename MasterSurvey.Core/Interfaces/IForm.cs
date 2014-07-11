using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Core.Interfaces
{
    interface IForm
    {
        String Label { get;  private set; }
        DateTime CreatedAt { get; private set; }

        IQuestion Questions { get; private set; }

        IReadOnlyDictionary<String, IFormAnswer> Answers { get; private set; }

        IFormAnswer AddOrCreateAnswerFor(String entity);
    }
}
