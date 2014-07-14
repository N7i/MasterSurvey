using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Core
{
    public interface IQuestion : IEnumerable
    {
        String Title { get; set; }

        String Tips { get; set; }

        bool AllowEmptyAnswer { get; set; }

        IQuestion AddNew(Type questionType, params object[] args);

        IQuestion AddNew(String questionType, params object[] args);

        IQuestion Questions { get; }

        bool Remove(IQuestion questionToRemove);

        Type GetAnswerType();
    }
}
