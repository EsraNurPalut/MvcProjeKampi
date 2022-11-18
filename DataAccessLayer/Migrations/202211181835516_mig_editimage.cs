namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_editimage : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.İmageFile");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.İmageFile",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        ImageName = c.String(maxLength: 100),
                        ImagePath = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ImageID);
            
        }
    }
}
