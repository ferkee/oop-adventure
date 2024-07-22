using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure
{
    public abstract class Character
    {
        public string Name { get; set; }

        // constructor 
        public Character(string name)
        {
            Name = name.Trim();
        }
    }
}
