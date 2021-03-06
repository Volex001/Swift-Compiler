﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swift.Instructions
{
    /// <summary>
    /// Shift left; Target = Target >> Register
    /// </summary>
    public class Shr : Instruction
    {
        public AssTarget Value { get; set; }
        public AssTarget Target { get; set; }
        public Shr(AssTarget value, AssTarget target)
        {
            Value = value;
            Target = target;
        }

        public override void accept(Visitor v)
        {
            v.visit(this);
        }
    }
}
