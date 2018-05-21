using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class ProgramA
    {
        static void Main(string[] args)
        {

            Console.WriteLine("______________________________Price Sum___________________________________");
            foreach (var item in InventoryManager.GetInventories())
            {
                Console.WriteLine($"{item.ID} : {item.Name} - {item.Price}");
            }
            var sum = InventoryManager.GetInventories().Sum(x => x.Price);
            Console.WriteLine("{0:C}", sum);



            Console.WriteLine("______________________________Price Average___________________________________");
            foreach (var item in InventoryManager.GetInventories())
            {
                Console.WriteLine($"{item.ID} : {item.Name} - {item.Price}");
            }
            var avg = InventoryManager.GetInventories().Average(x => x.Price);
            Console.WriteLine("{0:C}", avg);


            Console.WriteLine("       ");

            Console.WriteLine("______________________________Skip While___________________________________");
            var ski = InventoryManager.GetInventories().SkipWhile(x => x.ID < 005);

            foreach (var item in ski)
            {
                Console.WriteLine($"{item.ID} : {item.Name} - {item.Price} [{item.EntryDate}] {item.Categories} ");
            }


            
            Console.WriteLine("       ");

            Console.WriteLine("______________________________Take While___________________________________");
            var tak = InventoryManager.GetInventories().TakeWhile(x => x.Price < 35000);

            foreach (var item in tak)
            {
                Console.WriteLine($"{item.ID} : {item.Name} - {item.Price} [{item.EntryDate}] ");
            }



            Console.WriteLine("       ");

            Console.WriteLine("______________________________Orderby and Thenby___________________________________");
            var n = InventoryManager.GetInventories().OrderBy(x => x.ID).ThenBy(x => x.EntryDate);

            foreach (var item in n)
            {
                Console.WriteLine($"{item.ID} : {item.Name} - {item.Price} [{item.EntryDate}] ");
            }



            Console.WriteLine("       ");

            Console.WriteLine("______________________________Orderby descending and Thenby descending___________________________________");
            var Ord = InventoryManager.GetInventories().OrderByDescending(x => x.ID).ThenByDescending(x => x.EntryDate);

            foreach (var item in Ord)
            {
                Console.WriteLine($"{item.ID} : {item.Name} - {item.Price} [{item.EntryDate}] ");
            }

        }
    }
}
