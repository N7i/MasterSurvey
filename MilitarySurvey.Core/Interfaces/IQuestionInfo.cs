using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitarySurvey.Interfaces
{
    public interface IQuestionInfo
    {
        String Title { get; set; }

        String Tips { get; set; }

        bool AllowEmptyAnswer { get; set; }

        void Display();

        Type GetAnswerType();

        IAnswerInfo CreateAnswer();
    }
}
