using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Laba_6_Pattern
{
    // Этот класс отвечает за листок (сотрудника)
    public abstract class Tree_Leaf : Tree_Component
    {
        public Tree_Leaf() { IsLeaf = true; }

    }
}
