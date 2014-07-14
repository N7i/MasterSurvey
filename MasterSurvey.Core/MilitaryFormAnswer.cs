using MasterSurvey.Core;
using MasterSurvey.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Core
{
    public class MilitaryFormAnswer : IFormAnswer
    {
        Dictionary<IQuestion, IAnswer> _questionContainer;
        String _answerOwner;
        IForm _formOwner;

        
        public IReadOnlyDictionary<IQuestion, IAnswer> QuestionsContainer { get { return _questionContainer; } }

        public IForm OwnerForm { get { return _formOwner; } private set { _formOwner = value; } }
        public String AnswerOwner { get { return _answerOwner; } private set { _answerOwner = value;  } }

        public bool AddAnswer(IAnswer answer, IQuestion question)
        {
            if (_questionContainer.ContainsKey(question))
            {
                return false;
            }

            _questionContainer.Add(question, answer);
            return true;
        }

        

        public MilitaryFormAnswer(IForm owner)
        {
            OwnerForm = owner;
            _answerOwner = "Undefined";
        }
    }
}
