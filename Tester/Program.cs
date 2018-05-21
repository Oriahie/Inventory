using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace tester
{
    public class Fraction
    {
        private int num;
        private int denum;

        public Fraction(int num, int denum)
        {
            this.num = num;
            this.denum = denum;
        }

        public static Fraction operator+ (Fraction lhs, Fraction rhs)
        {
            
            if ( lhs.denum == rhs.denum )
            {
                return new Fraction( lhs.num + rhs.num,lhs.denum );
            }
        }


    }




    class Program
    {
        static void Main(string[] args)
        {
            




















        //     var states = new List<string>();
        //    {
        //        states.Add("Lagos");
        //        states.Add("Oshogbo");
        //        states.Add( "Delta");
        //    };

        //     foreach (var state in states)
        //     {
        //         Console.WriteLine(state);
        //     }



           var states = new Dictionary<string, string>();
           {
               states.Add("LAG", "Lagos");
               states.Add("OSG", "Oshogbo");
               states.Add("DEL", "Delta");
           };
                 foreach(var state in states)
                 {
                    var value = state.Value;
                    var key = state.Key;
                    System.Console.WriteLine($"{key} : {value}");
                 }

                 foreach(var state in states.Values)
                 {
                      System.Console.WriteLine( state);  
                 }

                foreach(var state in states.Keys)
                {
                   System.Console.WriteLine( state   );     
                }

              //  Console.WriteLine(states["LAG"]);
            
           
        }
    }
}
