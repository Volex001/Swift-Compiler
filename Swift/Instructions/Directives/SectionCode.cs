﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swift.Instructions.Directives
{
    public class SectionCode : Instruction
    {
        public override void accept(Visitor v)
        {
            v.visit(this);
        }
    }
}
