namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contents", "Writer_WriterID", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "Writer_WriterID" });
            RenameColumn(table: "dbo.Contents", name: "Writer_WriterID", newName: "WriterID");
            AlterColumn("dbo.Contents", "WriterID", c => c.Int(nullable: false));
            CreateIndex("dbo.Contents", "WriterID");
            AddForeignKey("dbo.Contents", "WriterID", "dbo.Writers", "WriterID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "WriterID", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "WriterID" });
            AlterColumn("dbo.Contents", "WriterID", c => c.Int());
            RenameColumn(table: "dbo.Contents", name: "WriterID", newName: "Writer_WriterID");
            CreateIndex("dbo.Contents", "Writer_WriterID");
            AddForeignKey("dbo.Contents", "Writer_WriterID", "dbo.Writers", "WriterID");
        }
    }
}
