using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Decorator
{
    internal class PollateInsect : InsectDecorator
    {
        public PollateInsect(Insect insect) : base(insect.Title + "+", insect)
        {
        }

        public override string getSkill()
        {
            return insect.getSkill() + " опылять";        }
    }
}
