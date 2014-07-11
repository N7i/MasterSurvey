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

        IReadOnlyList<IQuestion> Questions { get; private set; }

        void AppendQuestion(IQuestion question);

        void RemoveQuestion(IQuestion target);
        
        void MoveBefore(IQuestion target,IQuestion toMove );
        void MoveAfter(IQuestion target,IQuestion toMove);

        IReadOnlyDictionary<String, IFormAnswer> Answers { get; private set; }

        IFormAnswer AddOrCreateAnswerFor(String entity);
    }
}
