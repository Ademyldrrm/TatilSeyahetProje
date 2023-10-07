namespace TatilSeyehatProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_blogid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "Blog_ID", "dbo.Blogs");
            DropIndex("dbo.Comments", new[] { "Blog_ID" });
            RenameColumn(table: "dbo.Comments", name: "Blog_ID", newName: "Blogid");
            AddColumn("dbo.Comments", "Comments", c => c.String());
            AlterColumn("dbo.Comments", "Blogid", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "Blogid");
            AddForeignKey("dbo.Comments", "Blogid", "dbo.Blogs", "ID", cascadeDelete: true);
            DropColumn("dbo.Comments", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "Description", c => c.String());
            DropForeignKey("dbo.Comments", "Blogid", "dbo.Blogs");
            DropIndex("dbo.Comments", new[] { "Blogid" });
            AlterColumn("dbo.Comments", "Blogid", c => c.Int());
            DropColumn("dbo.Comments", "Comments");
            RenameColumn(table: "dbo.Comments", name: "Blogid", newName: "Blog_ID");
            CreateIndex("dbo.Comments", "Blog_ID");
            AddForeignKey("dbo.Comments", "Blog_ID", "dbo.Blogs", "ID");
        }
    }
}
