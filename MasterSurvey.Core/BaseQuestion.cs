﻿using MasterSurvey.Core;
using System;
using System.Collections;
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
        int _counter = 0;

        public String Title { get { return _title; } set { _title = value; } }
        public String Tips { get { return _tips; } set { _tips = value; } }

        public bool AllowEmptyAnswer { get { return _allowEmptyQuestion; } set { _allowEmptyQuestion = value; } }

        public int Count
        {
            get { return _counter;  }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IQuestion Questions { get { return _questions; } }

        public IQuestion AddNew(Type questionType, params object[] args)
        {
            throw new NotImplementedException();
        }

        public IQuestion AddNew(String questionType, params object[] args)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IQuestion questionToRemove)
        {
            // TODO --_counter;
            throw new NotImplementedException();
        }

        public abstract Type GetAnswerType();

        private IQuestion AddNew(IQuestion question)
        {
            ++_counter;
            throw new NotImplementedException();
        }

               
    }

    public class RootQuestion : BaseQuestion
    {
        public override Type GetAnswerType() { return null;  }
    }
}
