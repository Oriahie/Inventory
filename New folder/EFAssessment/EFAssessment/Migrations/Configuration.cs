namespace EFAssessment.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFAssessment.BlogDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFAssessment.BlogDBContext context)
        {
            var post1 = new Post
            {
                Title = "5 Reasons why you need to eat Healthy!",
                CreatedDate = DateTime.Now,
                Body = "Weight Loss, Energy, Gain Muscle, Look Good and finally to maintain a good Health"
            };

            var post2 = new Post
            {
                Title = "What not to wear",
                CreatedDate = DateTime.Now,
                Body = "Water dispenser cloth, Meaty shoes, Glass Slippers, well in all you do just look very presentable."
            };

            var post3 = new Post
            {
                Title = "Do you Know?",
                CreatedDate = DateTime.Now,
                Body = "-Do you know that my name is Emmanuel \n -Do you know that this my laptop is very slow \n -I am tired."
            };

            var post4 = new Post
            {
                Title = "Funniest names I've heard",
                CreatedDate = DateTime.Now,
                Body = "First just has to be Perpertual..lol \n -Who bears Nkanuya?"
            };

            var post5 = new Post
            {
                Title = "This is the last post",
                CreatedDate = DateTime.Now,
                Body = "That's all folks!!"

            };



            var author1 = new Author
            {
                FullName = "Chinwe Achebe",
                Posts = new List<Post>()
                {
                    post1,post2
                }
            };

            var author2 = new Author
            {
                FullName = "Motunrayo Idowu",
                Posts = new List<Post>()
                {
                    post3,post4,post5
                }

            };


            var blog1 = new Blog
            {
                Name = "Linda Ikeji's Blog",
                Posts = new List<Post>()
                {
                    post2,post4,post1
                }
            };

            var blog2 = new Blog
            {
                Name = "Muna's Blog",
                Posts = new List<Post>()
                {
                    post5,post3
                }

            };

            context.Set<Blog>().AddOrUpdate(c => c.Name, blog1);
            context.Set<Blog>().AddOrUpdate(c => c.Name, blog2);
            context.Set<Author>().AddOrUpdate(c => c.FullName, author1);
            context.Set<Author>().AddOrUpdate(c => c.FullName, author2);
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
        

    }
}
