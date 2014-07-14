using MasterSurvey.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Ext.FreeQuestion
{
    public class FreeAnswer : BaseAnswer
    {
        String _answer = String.Empty;

        public FreeAnswer(IQuestion lkQ) : base(lkQ) { }

        public String Answer { get { return _answer; } set { _answer = value; } }

        public override bool IsValid()
        {
            if (Answer == String.Empty && !base.LinkedQuestion.AllowEmptyAnswer) {
                return false;
            }
            return true;
        }
    }
}
