using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_______________________________Union_______________________________");
            var n = InventoryManager.GetInventories().Union(InventoryManager.FreshInventories(), new UnionComaparer());

            foreach (var item in n)
            {
                Console.WriteLine($"{item.ID} : {item.Name} - {item.Price} [{item.EntryDate}] ");
            }

            Console.WriteLine("       ");



            Console.WriteLine("______________________Concat_______________________________");

            var y = InventoryManager.GetInventories().Concat(InventoryManager.FreshInventories());

            foreach (var item in y)
            {
                Console.WriteLine($"{item.ID} : {item.Name} - {item.Price} [{item.EntryDate}] ");
            }

            Console.WriteLine("       ");
            
            Console.WriteLine("______________________________Intercept___________________________________");

            var result = InventoryManager.GetInventories().Intersect(InventoryManager.FreshInventories(), new UnionComaparer());

            
            foreach (var item in result)
            {
                Console.WriteLine($"{item.ID} : {item.Name} - {item.Price} [{item.EntryDate}]");
            }

            Console.WriteLine("       ");
            Console.WriteLine("______________________________Distinct___________________________________");
            var d = InventoryManager.GetInventories().Distinct();


            foreach (var item in d)
            {
                Console.WriteLine($"{item.ID} : {item.Name} - {item.Price} [{item.EntryDate}]");
            }

            Console.WriteLine("       ");

            Console.WriteLine("______________________________Except___________________________________");

            var exc = InventoryManager.GetInventories().Except(InventoryManager.FreshInventories(), new UnionComaparer());


            foreach (var item in exc)
            {
                Console.WriteLine($"{item.ID} : {item.Name} - {item.Price} [{item.EntryDate}]");
            }



        }
    }
}
