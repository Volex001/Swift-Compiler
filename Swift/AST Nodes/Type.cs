﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swift.AST_Nodes
{
    public abstract class Type
    {
        public abstract void accept(Visitor n);
    }
}
