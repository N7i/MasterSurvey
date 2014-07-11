using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Core.Interfaces
{
    interface IForm
    {
        String Title { get;  private set; }
        DateTime CreatedAt { get; private set; }

        IReadOnlyList<IQuestion> Questions { get; private set; }

        void AddQuestion(IQuestion question);

        void InsertQuestionBefore(IQuestion target, IQuestion question);

        void InsertQuestionAfter(IQuestion target, IQuestion question);

        void RemoveQuestion(IQuestion target);
    }
}
