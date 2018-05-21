using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssessment
{
    public class BaseModel
    {
        public int Id { get; set; }
    }
    public class Blog : BaseModel
    {
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }

    public class Post : BaseModel
    {
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Body { get; set; }
        public List<Tag> Tags { get; set; }

    }

    public class Author : BaseModel
    {
        public string FullName { get; set; }
        public List<Post> Posts { get; set; }
    }

    public class Tag : BaseModel
    {
        public string Name { get; set; }
    }


    public class BlogDBContext : DbContext
    {
        public BlogDBContext() : base("BlogDBContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BlogMap());
            modelBuilder.Configurations.Add(new AuthorMap());
            modelBuilder.Configurations.Add(new PostMap());

        }

    }

}
