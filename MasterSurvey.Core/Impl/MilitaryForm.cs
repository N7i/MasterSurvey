﻿using MasterSurvey.Core;
using MasterSurvey.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Impl
{
    public class MilitaryForm : IForm
    {
        String _label = String.Empty;
        readonly DateTime _createdAt = new DateTime();
        Dictionary<String, MilitaryFormAnswer> _answers;
        IQuestion _rootQuestion = new RootQuestion();

        public String Label
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

        public IReadOnlyDictionary<string, MilitaryFormAnswer> Answers
        {
            get { return _answers;  }
        }

        public MilitaryFormAnswer AddOrCreateAnswerFor(string entity)
        {
            MilitaryFormAnswer formAnswer = null;
            _answers.TryGetValue(entity, out formAnswer);

            if (null == formAnswer)
            {
                formAnswer = new MilitaryFormAnswer(this);
                _answers.Add(entity, formAnswer);
            }
            return formAnswer;
        }
    }
}
