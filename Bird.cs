using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Class_Github
{
    class Bird: Animal
    {
        public int WingSpan { get; private set; }
        public bool CanFly { get; private set; }
        public bool IsCarnivore { get; private set; }
        public bool IsBirdOfprey { get; private set; }
        public bool IsNocturnal { get; private set; }
    }
}
