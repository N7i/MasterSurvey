using MasterSurvey.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Impl
{
    abstract class BaseQuestion : IQuestion
    {
        String _title = String.Empty;
        String _tips = String.Empty;
        List<IQuestion> _questions;

        public String Title { get { return _title; } set { _title = value; } }
        public String Tips { get { return _tips; } set { _tips = value; } }

        public IReadOnlyList<IQuestion> Questions { get { return _questions; } }

        public object AddNew(Type questionType, params object[] args)
        {
            return new Object();
        }

        public bool Remove(IQuestion questionToRemove)
        {
            return false;
        }

        public abstract String GetAnswerType();
    }
}
