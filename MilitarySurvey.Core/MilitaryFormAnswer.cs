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
    public class MilitaryFormAnswer
    {
        MilitaryForm _linkedForm;
        Dictionary<IQuestionInfo, IAnswerInfo> _questionsAnswer;

        public MilitaryFormAnswer(MilitaryForm linkedForm)
        {
            if (null == linkedForm) { throw new InvalidOperationException("Eat my short");  }
            _linkedForm = linkedForm;
        }

        IAnswerInfo FindAnswerOf(IQuestionInfo question)
        {
            IAnswerInfo answer = null;
            _questionsAnswer.TryGetValue(question, out answer);

            return answer;
        }

        public bool AddAnswerFor(IQuestionInfo question)
        {
            if (null == FindAnswerOf(question))
            {
                _questionsAnswer.Add(question, question.CreateAnswer());
                return true;
            }
            return false;
        }

        public bool isFormValid()
        {
            return !HaveInvalidAnswers(_linkedForm.Questions);
        }

        private bool HaveInvalidAnswers(IQuestionInfo questionInfo)
        {
            if (questionInfo is QuestionGroup)
            {
                var qGroup = questionInfo as QuestionGroup;
                IEnumerator<IQuestionInfo> it = qGroup.GetEnumerator();
                bool haveInvalidAnswers = false;

                while (it.MoveNext() && false == haveInvalidAnswers)
                {
                    haveInvalidAnswers = HaveInvalidAnswers(it.Current);
                }

                return haveInvalidAnswers;
            }
            else
            {
                return HaveInvalidAnswerFor(questionInfo);
            }
        }

        private bool HaveValidAnswerFor(IQuestionInfo question)
        {
            if (!question.AllowEmptyAnswer)
            {
                IAnswerInfo answer = FindAnswerOf(question);
                if (null == answer || answer.IsEmpty())
                {
                    return false;
                }
            }
            return true;
        }

        private bool HaveInvalidAnswerFor(IQuestionInfo question)
        {
            return !HaveValidAnswerFor(question);
        }
    }
}
