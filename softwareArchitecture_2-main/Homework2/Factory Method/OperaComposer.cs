using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Factory_Method
{
    internal class OperaComposer : Composers
    {
        public override Composition createComposition()
        {
            return new Opera();
        }
    }
}
