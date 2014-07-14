using MilitarySurvey.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitarySurvey.Ext.OpenQuestion
{
    public class OpenAnswer : AnswerBase
    {

        public String FreeAnswer { get; set; }

        public override bool IsEmpty()
        {
            return FreeAnswer == String.Empty;
        }
    }
}
