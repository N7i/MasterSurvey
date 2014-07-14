using MilitarySurvey.Core;
using MilitarySurvey.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitarySurvey.Core
{
    class SimplePluginLoader : IPluginLoader<IQuestionInfo>
    {
        private String pluginsFolder = "./plugins";

        public IQuestionInfo loadFromAssemblyInfo(string assemblyInfo)
        {
            throw new NotImplementedException();
        }

        public IQuestionInfo loadFromType(Type typetoLoad)
        {
            throw new NotImplementedException();
        }
    }
}
