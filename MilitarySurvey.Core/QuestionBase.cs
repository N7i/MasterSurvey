using MilitarySurvey.Core;
using MilitarySurvey.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitarySurvey.Core
{
    public abstract class QuestionBase : IQuestionInfo
    {
        public String Title { get; set; }
        
        public String Tips { get; set; }

        public bool AllowEmptyAnswer { get; set; }

        public abstract Type GetAnswerType();

        public abstract IAnswerInfo CreateAnswer();

        public abstract void Display();
    }
}
