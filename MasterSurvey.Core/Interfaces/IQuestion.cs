using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Core
{
    interface IQuestion
    {
        String Title;

        String Tips;

        IReadOnlyCollection<IQuestion> Questions;

        void AddQuestion(IQuestion question);
        void RemoveQuestion(IQuestion question);

        String AnswerType;
    }
}
