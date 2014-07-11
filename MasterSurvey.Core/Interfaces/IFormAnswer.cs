using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Core
{
    class IFormAnswer
    {
        IReadOnlyDictionary<IQuestion, IAnswer> QuestionsContainer;

        bool AddAnswer(IAnswer answer, IQuestion question);

        String Owner { get; private set; }
    }
}
