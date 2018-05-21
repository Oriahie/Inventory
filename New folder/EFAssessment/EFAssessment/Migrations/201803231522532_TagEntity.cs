namespace EFAssessment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TagEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Post_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.Post_Id)
                .Index(t => t.Post_Id);
            
            AlterColumn("dbo.Posts", "Body", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "Post_Id", "dbo.Posts");
            DropIndex("dbo.Tags", new[] { "Post_Id" });
            AlterColumn("dbo.Posts", "Body", c => c.String(maxLength: 1500));
            DropTable("dbo.Tags");
        }
    }
}
