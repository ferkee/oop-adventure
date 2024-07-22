using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure
{
    // "command pattern"
    public abstract class Action
    {
        // as virtual, other classes that extend Action are able to override the getter & setter
        public virtual string Name => "";
        public virtual void Execute(string[] args)
        {
            // "in case a new Action is created but we forget override Execute" 
            throw new Exception("Nothing to execute");
        }
    }
}
