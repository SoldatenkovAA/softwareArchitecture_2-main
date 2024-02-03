using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Decorator
{
    public class Butterfly : Insect
    {
       public Butterfly() : base("Бабочка") {}

        public override string getSkill()
        {
            return "радовать";
        }
    }
}
