using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Factory_Method
{
    internal class Song : Composition
    {
        public Song() {
            Console.WriteLine("Новая песня написана");
        }
    }
}
