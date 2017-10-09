namespace CenterWebMake.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sseee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhotoControl",
                c => new
                    {
                        Title = c.String(maxLength: 50),
                        UploadDate = c.String(maxLength: 50),
                        LoadPosition = c.String(maxLength: 50),
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhotoControl");
        }
    }
}
