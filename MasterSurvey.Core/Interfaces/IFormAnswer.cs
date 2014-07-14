using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Core
{
    public interface IFormAnswer
    {
        IReadOnlyDictionary<IQuestion, IAnswer> QuestionsContainer { get; }

        bool AddAnswer(IAnswer answer, IQuestion question);

        String AnswerOwner { get; }
    }
}
