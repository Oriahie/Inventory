namespace EFAssessment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false),
                        Body = c.String(maxLength: 1500),
                        Blog_Id = c.Int(),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.Blog_Id)
                .ForeignKey("dbo.Authors", t => t.Author_Id)
                .Index(t => t.Blog_Id)
                .Index(t => t.Author_Id);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.Posts", "Blog_Id", "dbo.Blogs");
            DropIndex("dbo.Posts", new[] { "Author_Id" });
            DropIndex("dbo.Posts", new[] { "Blog_Id" });
            DropTable("dbo.Authors");
            DropTable("dbo.Posts");
            DropTable("dbo.Blogs");
        }
    }
}
