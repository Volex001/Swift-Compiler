﻿using Swift.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swift
{
    class SyntaxAnalyzer
    {
        public static AST CheckSyntax(List<Token> tokens, List<LineContext> context)
        {
            AST astBase = new AST(context[0]);
            return astBase;
        }
    }
}
