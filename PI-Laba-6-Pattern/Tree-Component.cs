using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PI_Laba_6_Pattern
{
    // Этот класс отвечает за отдельный элемент в дереве
    public abstract class Tree_Component
    {
        public bool IsLeaf { get; protected set; }

    }
}
