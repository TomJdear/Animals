using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_life
{
    public class Reptile_Species : Animal
    {
        public bool coldBlooded { get; set; }
        public bool hasFangs { get; set; }
        public bool Venomous { get; set; }

        private Reptile_Species()
        {
            bool coldBlooded = true;
        }

        public Reptile_Species(bool hasfangs, bool venomous)
        {
            hasFangs = hasfangs;
            Venomous = venomous;
        }
    }
}
