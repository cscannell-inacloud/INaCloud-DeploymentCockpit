﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeploymentCockpit.Interfaces
{
    public interface IScriptRunner
    {
        string Run(string scriptBody, ScriptType scriptType);
    }
}
