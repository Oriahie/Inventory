using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssessment
{
    public class BlogMap : EntityTypeConfiguration<Blog>
    {
        public BlogMap()
        {
            this.Property(c => c.Name).HasMaxLength(50);
            
        }
    }

    public class PostMap : EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            this.Property(c => c.Title).HasMaxLength(150);
            this.Property(c => c.Body).HasMaxLength(25000);
        }
    }

    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            this.Property(c => c.FullName).HasMaxLength(250);
        }
    }

    public class TagMap : EntityTypeConfiguration<Tag>
    {
        public TagMap()
        {
            this.Property(c => c.Name).HasMaxLength(250);
        }
    }
}
