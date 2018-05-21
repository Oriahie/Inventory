using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise.No1_3
{
    abstract class Animal
    {
        private int weight;
        private string name;

        public abstract void Speak();
        public abstract void Move();
        public abstract void ToString();
    }

    class Cat : Animal
    {
        public override void Move()
        {
            Console.WriteLine("The cat moves");
        }

        public override void Speak()
        {
            Console.WriteLine("The cat meows");
        }

        public override void ToString()
        {
            Console.WriteLine("This prints out he string");
        }
    }


    class Dog : Animal
    {
        public override void Move()
        {
            Console.WriteLine("The dog runs");
        }

        public override void Speak()
        {
            Console.WriteLine("The dog barks");
        }

        public override void ToString()
        {
            Console.WriteLine("This prints out he string");
        }
    }

}
