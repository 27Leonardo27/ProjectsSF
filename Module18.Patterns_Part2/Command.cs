﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Patterns_Part2
{
    abstract class Command
    {
        public abstract void Run();
        public abstract void Cancel();
    }
}
