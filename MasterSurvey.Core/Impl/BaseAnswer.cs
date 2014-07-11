using MasterSurvey.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSurvey.Impl
{
    abstract class BaseAnswer : IAnswer
    {
        public abstract bool IsValid();
    }
}
