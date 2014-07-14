using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterSurvey.Core;

namespace MasterSurvey.Ext.FreeQuestion
{
    public class FreeQuestion : BaseQuestion
    {
        public override Type GetAnswerType()
        {
            return typeof(FreeAnswer);
        }
    }
}
