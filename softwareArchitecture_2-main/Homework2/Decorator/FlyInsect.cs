using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Decorator
{
    internal class FlyInsect : InsectDecorator
    {
        public FlyInsect(Insect insect) : base(insect.Title + "+", insect)
        {
        }

        public override string getSkill()
        {
            return insect.getSkill() + " летать";
        }
    }
}
