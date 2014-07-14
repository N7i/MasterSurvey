using MilitarySurvey.Core;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitarySurvey
{
    public class MilitaryForm
    {

        Dictionary<string, MilitaryFormAnswer> _answers;
        QuestionGroup _questions;

        public QuestionGroup Questions { get { return _questions; } }

        #region constructor
        public MilitaryForm() : this (new QuestionGroup(new SimplePluginLoader()), new Dictionary<string,MilitaryFormAnswer>()) 
        {
        }

        public MilitaryForm(QuestionGroup questions) : this(questions, new Dictionary<string, MilitaryFormAnswer>()) 
        {
        }

        public MilitaryForm(QuestionGroup questions, Dictionary<string, MilitaryFormAnswer> answers)
        {
            if (questions == null || answers == null) { throw new ArgumentNullException("Should not be null !");  }

            _questions = questions;
            _answers = answers;
        }
        #endregion

        public MilitaryFormAnswer FindOrCreateAnswerFor(string answerKey)
        {
            MilitaryFormAnswer formAnswer = null;
            _answers.TryGetValue(answerKey, out formAnswer);

            if (null == formAnswer)
            {
                formAnswer = new MilitaryFormAnswer(this);
                _answers.Add(answerKey, formAnswer);
            }

            return formAnswer;
        }

    }
}
