namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_editwriter : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Headings", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Contents", "HeadingID", "dbo.Headings");
            DropForeignKey("dbo.Headings", "WriterID", "dbo.Writers");
            DropIndex("dbo.Headings", new[] { "CategoryID" });
            DropIndex("dbo.Headings", new[] { "WriterID" });
            DropIndex("dbo.Contents", new[] { "HeadingID" });
            AlterColumn("dbo.Headings", "CategoryID", c => c.Int(nullable: false));
            AlterColumn("dbo.Headings", "WriterID", c => c.Int(nullable: false));
            AlterColumn("dbo.Contents", "HeadingID", c => c.Int(nullable: false));
            CreateIndex("dbo.Headings", "CategoryID");
            CreateIndex("dbo.Headings", "WriterID");
            CreateIndex("dbo.Contents", "HeadingID");
            AddForeignKey("dbo.Headings", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
            AddForeignKey("dbo.Contents", "HeadingID", "dbo.Headings", "HeadingID", cascadeDelete: true);
            AddForeignKey("dbo.Headings", "WriterID", "dbo.Writers", "WriterID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Headings", "WriterID", "dbo.Writers");
            DropForeignKey("dbo.Contents", "HeadingID", "dbo.Headings");
            DropForeignKey("dbo.Headings", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Contents", new[] { "HeadingID" });
            DropIndex("dbo.Headings", new[] { "WriterID" });
            DropIndex("dbo.Headings", new[] { "CategoryID" });
            AlterColumn("dbo.Contents", "HeadingID", c => c.Int());
            AlterColumn("dbo.Headings", "WriterID", c => c.Int());
            AlterColumn("dbo.Headings", "CategoryID", c => c.Int());
            CreateIndex("dbo.Contents", "HeadingID");
            CreateIndex("dbo.Headings", "WriterID");
            CreateIndex("dbo.Headings", "CategoryID");
            AddForeignKey("dbo.Headings", "WriterID", "dbo.Writers", "WriterID");
            AddForeignKey("dbo.Contents", "HeadingID", "dbo.Headings", "HeadingID");
            AddForeignKey("dbo.Headings", "CategoryID", "dbo.Categories", "CategoryID");
        }
    }
}
