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

        IAnswer FindAnswer(IQuestion question);

        IAnswer AddAnswerFor(IQuestion question);

        String AnswerOwner { get; }
    }
}
