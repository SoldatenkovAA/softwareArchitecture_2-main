using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Factory_Method
{
    internal class Dance : Composition
    {
        public Dance() {
            Console.WriteLine("Новый танец написан!");
        }
    }
}
