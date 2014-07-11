using MasterSurvey.Core;
using MasterSurvey.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Impl
{
    public class MilitaryFormAnswer : IFormAnswer
    {
        Dictionary<IQuestion, IAnswer> _questionContainer;


        IReadOnlyDictionary<IQuestion, IAnswer> QuestionsContainer { get { return _questionContainer; } }

        bool AddAnswer(IAnswer answer, IQuestion question)
        {
            if (_questionContainer.ContainsKey(question))
            {
                return false;
            }

            _questionContainer.Add(question, answer);
            return true;
        }

        IForm OwnerForm { get; private set; }

        public MilitaryFormAnswer(IForm owner)
        {
            OwnerForm = owner;

        }
    }
}
