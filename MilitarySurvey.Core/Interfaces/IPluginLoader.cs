﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitarySurvey.Interfaces
{
    public interface IPluginLoader<T>
    {
        T loadFromAssemblyInfo(string assemblyInfo);

        T loadFromType(Type typetoLoad);
    }
}
