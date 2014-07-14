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
    public class QuestionGroup : QuestionBase, IEnumerable<IQuestionInfo>
    {

        //TODO AllowEmptyAnswer
        //TODO

        List<IQuestionInfo> _child;
        IPluginLoader<IQuestionInfo> _pLoader;

        public QuestionGroup(IPluginLoader<IQuestionInfo> loader) {
            _pLoader = loader;
        }

        public IQuestionInfo AddNewQuestion(string assemblyInfo)
        {
            IQuestionInfo q =  _pLoader.loadFromAssemblyInfo(assemblyInfo);
            _child.Add(q);

            return q;
        }

        public IQuestionInfo AddNewQuestion(Type questionType)
        {
            IQuestionInfo q = _pLoader.loadFromType(questionType);
            _child.Add(q);

            return q;
        }

        public bool RemoveQuestion(QuestionBase toRemove)
        {
            return _child.Remove(toRemove);
        }

        public IReadOnlyCollection<IQuestionInfo> Child { get { return _child.AsReadOnly();  } }

        public override void Display()
        {
            foreach (IQuestionInfo question in _child) {
                question.Display();
            }
        }

        public override Type GetAnswerType()
        {
            return typeof(AnswerGroup);
        }

        public override IAnswerInfo CreateAnswer()
        {
            // TODO
            return new AnswerGroup();
        }

        public IEnumerator<IQuestionInfo> GetEnumerator()
        {
            return _child.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
