using MasterSurvey.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Core
{
    public abstract class BaseQuestion : IQuestion
    {
        String _title = String.Empty;
        String _tips = String.Empty;
        bool _allowEmptyQuestion = true;
        IQuestion _questions;

        public String Title { get { return _title; } set { _title = value; } }
        public String Tips { get { return _tips; } set { _tips = value; } }

        public bool AllowEmptyAnswer { get { return _allowEmptyQuestion; } set { _allowEmptyQuestion = value; } }

        public IQuestion Questions { get { return _questions; } }

        public object AddNew(Type questionType, params object[] args)
        {
            throw new NotImplementedException();
        }

        public object AddNew(String questionType, params object[] args)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IQuestion questionToRemove)
        {
            throw new NotImplementedException();
        }

        public abstract Type GetAnswerType();
    }

    public class RootQuestion : BaseQuestion
    {
        public override Type GetAnswerType() { return null;  }
    }
}
