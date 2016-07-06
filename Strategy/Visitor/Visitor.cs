﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class Visitor
    {
        public abstract void visitConcreteElementA(ConcreteElementA cea);
        public abstract void visitConcreteElementB(ConcreteElementB ceb);

    }
}
