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

        object AddNew(Type questionType, params object[] args);

        IReadOnlyCollection<IQuestion> Questions;

        bool Remove(IQuestion questionToRemove);

        String GetAnswerType();
    }
}
