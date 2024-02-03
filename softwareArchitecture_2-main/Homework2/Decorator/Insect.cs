using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Decorator
{
    public abstract class Insect
    {
        public string Title { get; protected set; }
        public Insect(string title) {
            Title = title;
        }

        public abstract string getSkill();
    }
}
