using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class InventoryManager
    {
        public static IEnumerable<Inventory> GetInventories()
        {
            List<Inventory> Inventories = new List<Inventory>()
            {
                new Inventory()
                {
                    ID = 001,
                    Name = "Kitchen Knife",
                    Price = 2500,
                    EntryDate = DateTime.Now,
                    Categories = new List<Category>{ GetCategories()[0] }
                },


            new Inventory()
            {
                ID = 002,
                Name = "BlueTooth Mouse",
                Price = 7000,
                EntryDate = DateTime.Now,
                Categories = new List<Category> { GetCategories()[2] }
            },

            new Inventory()
            {
                ID = 003,
                Name = "Table",
                Price = 1700,
                EntryDate = DateTime.Now,
                Categories = new List<Category> { GetCategories()[0], GetCategories()[1] }
            },

            new Inventory()
            {
                ID = 004,
                Name = "Blender",
                Price = 12000,
                EntryDate = DateTime.Now,
                Categories = new List<Category> { GetCategories()[0] }
            },

            new Inventory()
            {
                ID = 005,
                Name = "Printer",
                Price = 35000,
                EntryDate = DateTime.Now,
                Categories = new List<Category> { GetCategories()[1], GetCategories()[2] }
            },

            new Inventory()
            {
                ID = 006,
                Name = "External Webcam",
                Price = 9000,
                EntryDate = DateTime.Now,
                Categories = new List<Category> { GetCategories()[1], GetCategories()[2] }
            },

            new Inventory()
            {
                ID = 007,
                Name = "Refrigerator",
                Price = 65000,
                EntryDate = DateTime.Now,
                Categories = new List<Category> { GetCategories()[0] }
            },

            new Inventory()
            {
                ID = 008,
                Name = "Hp Keyboard",
                Price = 2000,
                EntryDate = DateTime.Now,
                Categories = new List<Category> { GetCategories()[1], GetCategories()[2] }
            },

            new Inventory()
            {
                ID = 009,
                Name = "Water Dispenser",
                Price = 23000,
                EntryDate = DateTime.Now,
                Categories = new List<Category> { GetCategories()[0], GetCategories()[1] }
            },


            new Inventory()
            {
                ID = 010,
                Name = "Projector",
                Price = 2500,
                EntryDate = DateTime.Now,
            }

            };


            


            return Inventories;

        }

        public static IEnumerable<Inventory> FreshInventories()
        {
            List<Inventory> inventories = new List<Inventory>()
            {
                 new Inventory()
                {
                    Name = "Gas Burner",
                    Price = 40000,
                     Categories = new List<Category> { GetCategories()[0]}
                },
                 
                 new Inventory()
                {
                    Name = "Table",
                    Price = 1700,
                     Categories = new List<Category> { GetCategories()[1]}
                },

                 new Inventory()
                {
                    Name = "Pressing Iron",
                    Price = 3200,
                     Categories = new List<Category> { GetCategories()[0]}
                },


                 new Inventory()
                {
                    Name = "Samsung Phone Casing",
                    Price = 1200,
                     Categories = new List<Category> { GetCategories()[2]}
                },

                 new Inventory()
                {
                    Name = "Scanner",
                    Price = 25000,
                     Categories = new List<Category> { GetCategories()[1], GetCategories()[2] }
                },

                 
            };
            return inventories;
        }


        public static List<Category> GetCategories()
        {
            var categories = new Category[]
            {
                new Category(){Name = "House Hold Appliances"},
                new Category(){Name = "Office Equipment"},
                new Category(){Name = "Computer Accesories"}
            };
            
            return categories.ToList();
        }

    }

    public class Inventory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime EntryDate { get; set; } = DateTime.Now;
        public List<Category> Categories { get; set; } = new List<Category>();

    }

    public class Category
    {
        public string Name { get; set; }

    }


    public class UnionComaparer : IEqualityComparer<Inventory>
    {
        public bool Equals(Inventory x, Inventory y)
        {
            return x.Name == y.Name ;
        }

        public int GetHashCode(Inventory obj)
        {
            return obj.Name.GetHashCode();
         }
    }





}
