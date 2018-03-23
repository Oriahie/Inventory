using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
           // AddandEdit();
           // GetAll();
           // GetSingle();
           // Delete();
           // FindBy();
            Console.WriteLine("Success!!");
        }

        private static void GetSingle()
        {
            var context = new BlogRepository<BlogDBContext, Post>();
            var item = context.GetSingle(2);

            Console.WriteLine($"{item.Id}** {item.Title} || {item.Body}");
        }

        private static void GetAll()
        {
            var context = new BlogRepository<BlogDBContext, Post>();
            var result = context.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Id}** {item.Title} || {item.Body}");
            }

        }

        private static void AddandEdit()
        {
            var Post1 = new Post
            {
                Title ="Testing the Add",
                CreatedDate = DateTime.Now,
                Body = "This is a means of testing the add from IRepository"
            };

            var Post2 = new Post
            {
                Title = "Testing the Add",
                CreatedDate = DateTime.Now,
                Body = "This is a means of testing the Edit from IRepository"
            };
            
            

            var context = new BlogRepository<BlogDBContext, Post>();
             context.Add(Post2);
            Post2.Title = "Testing the Edit";
            context.Edit(Post2);
        }

        private static void Delete()
        {
            var context = new BlogRepository<BlogDBContext, Post>();
            
            context.Delete(3);
            
        }

        private static void FindBy()
        {
            var context = new BlogRepository<BlogDBContext, Post>();
            var result = context.FindBy(c=>c.Body.Contains("look"));
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Id}** {item.Title} || {item.Body}");
            }
            
        }

    }
}
