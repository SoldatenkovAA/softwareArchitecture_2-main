using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Factory_Method
{
    internal class Opera : Composition
    {
        public Opera() {
            Console.WriteLine("Новая опера создана...");
        }
    }
}
