using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF_Animal_Kingdom_andy
{
    public class Animal
    {
        public bool HasLegs { get; private set; }
        public int Age { get; set; }
        public int YearsAtZoo { get; set; }
        public bool IsMale { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("Noises like an animal!");
        }
        public override string ToString()
        {
            return "I'm an animal!";
        }
        public override bool ReadyToBreed(int age, bool isMale)
        {

        }
    }
}
