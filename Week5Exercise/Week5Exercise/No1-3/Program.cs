using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Exercise.No1_3;

namespace Week5Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[8];
            {
                new Dog(20, "Mark");
                new Cat(13, "Marly");                

                new Dog(13, "Suzzy");
                new Cat(14, "Zara");                
                
                new Dog(12, "Rath");
                new Cat(17, "Railey");
            }



            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Move());
                Console.WriteLine(animal.Speak());
                Console.WriteLine(animal.ToString());
            }



        }
    
    }
}
