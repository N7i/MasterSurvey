using MasterSurvey.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Core
{
    public abstract class BaseAnswer : IAnswer
    {
        //TODO should be readonly config object
        protected IQuestion LinkedQuestion { get; private set; }

        private BaseAnswer() { throw new NotSupportedException();  }

        public BaseAnswer(IQuestion linkedQuestion)
        {
            LinkedQuestion = linkedQuestion;
        }
        public abstract bool IsValid();
    }
}
