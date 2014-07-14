using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitarySurvey.Core;
using MilitarySurvey.Interfaces;

namespace MilitarySurvey.Ext.OpenQuestion
{
    public class OpenQuestion : QuestionBase
    {
        public override Type GetAnswerType()
        {
            return typeof(OpenAnswer);
        }

        public override IAnswerInfo CreateAnswer()
        {
            return new OpenAnswer();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
