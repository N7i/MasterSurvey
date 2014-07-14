using MasterSurvey.Core;
using MasterSurvey.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Core
{
    public class MilitaryForm : IForm
    {
        String _label = String.Empty;
        readonly DateTime _createdAt = new DateTime();
        Dictionary<String, IFormAnswer> _formAnswers = new Dictionary<string,IFormAnswer>();
        IQuestion _rootQuestion = new RootQuestion();

        public String Title
        {
            get { return _label; }
            set { _label = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public IQuestion Questions
        {
            get { return _rootQuestion; }
        }

        public IReadOnlyDictionary<string, IFormAnswer> Answers
        {
            get { return _formAnswers;  }
        }

        public IFormAnswer FindOrCreateAnswerFor(string entity)
        {
            IFormAnswer formAnswer = null;
            _formAnswers.TryGetValue(entity, out formAnswer);

            if (null == formAnswer)
            {
                formAnswer = new MilitaryFormAnswer(this);
                _formAnswers.Add(entity, formAnswer);
            }
            return formAnswer;
        }
    }
}
