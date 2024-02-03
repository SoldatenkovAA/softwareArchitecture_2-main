using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Decorator
{
    internal class Beatle : Insect
    {
        public Beatle() : base("Жук")
        {
        }

        public override string getSkill()
        {
            return "жужжать";
        }
    }
}
