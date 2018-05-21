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
            Animal[] animals = new Animal[2];
            {
                new Dog();
                new Cat();
            }



            foreach (var animal in animals)
            {
                animal.Move();
                animal.Speak();
                animal.ToString();
            }



        }
    
    }
}
