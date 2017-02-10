using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor & property syntax
            // Make a new lion, have it make noise
            Lion lion = new Lion("Simba");
            lion.age = 5;
            lion.makeNoise();

            // Object  Initalizer Syntax
            // Make a new bear, have it make noise
            Bear bear = new Bear("Baloo")
            {
                age = 12
            };
            bear.makeNoise();


            // Slap them into a generic Animal array, 
            Animal[] animals = { lion, bear };

            // Now we just have an array of animals!
            // What happens when they makeNoise()
            // The animals show polymorphism, as each shows a different
            // Behavior for the makeNoise method.
            Console.WriteLine("Let's see all the animals make noise!");
            foreach (Animal a in animals)
            {
                Console.WriteLine("Meet " + a.name + ".");
                a.makeNoise();
                Console.WriteLine("Can you guess what animal they are?");
            }





            Console.ReadKey();
        }
    }
}
