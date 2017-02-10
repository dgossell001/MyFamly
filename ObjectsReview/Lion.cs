using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsReview
{
    class Lion : Animal
    {
        
        public Lion(String name):base(name)
        {
            
        }

        // Here we override the base class method to 
        // make our lion's roar.
        public override void makeNoise()
        {
            Console.WriteLine("Roar!");
        }
    }
}
