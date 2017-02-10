using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsReview
{
    class Bear : Animal
    {
        public Bear(String name):base(name)
        {

        }

        // Here we override the base class method to 
        // make our bear's grrr...
        public override void makeNoise()
        {
            Console.WriteLine("Grrr!");
        }
    }
}
