using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Decorator
{
    public abstract class InsectDecorator : Insect
    {
        public Insect insect;
        public InsectDecorator(string title, Insect insect) : base(title)
        {
            this.insect = insect;
        }
    }
}
