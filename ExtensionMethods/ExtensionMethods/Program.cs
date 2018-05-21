using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Program
    {

        public class Car
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
        }



        public static void Main()
        {
            Car car1 = new Car() { Make = "Toyota", Model = "Camry", VIN = "100" };
            Car car2 = new Car() { Make = "Nissan", Model = "Exo", VIN = "101" };


            /*  var myDate = new DateTime(2018, 02, 27);
              Console.WriteLine(myDate); ;
              Console.WriteLine(myDate.ToCyberDateTime());
              */


            /* Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);
            Console.WriteLine(myDictionary["100"].Model); */



            Console.WriteLine("Insert a number");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Delimiter(input));

        }

        /* public static DateTime ToCyberDateTime(this DateTime value)
        {
            return DateTime.Now;
        } */

        public static string Delimiter(this int value)
         {
            
             string s = "#";
             for (int i = 0; i < value.ToString().Length / 3; i++) s += @"\,###";

             string output = string.Format(@"{0:" + s + "}", value);

            

            return output;
         } 



    }
}
