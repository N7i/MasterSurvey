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

        public IAnswer FindAnswer(IQuestion question)
        {
            IAnswer answer = null;
            _questionContainer.TryGetValue(question, out answer);

            return answer;
        }

        public IAnswer AddAnswerFor(IQuestion question)
        {
            if (null != FindAnswer(question)) { throw new InvalidOperationException("An anwser already exist for that question");  }

            IAnswer anwser = (IAnswer) Activator.CreateInstance(
                                        question.GetAnswerType(), 
                                        question
                                        );

            _questionContainer.Add(question, anwser);
            return anwser;
        }

        
        public MilitaryFormAnswer(IForm owner)
        {
            OwnerForm = owner;
            _answerOwner = "Undefined";
        }
    }
}
