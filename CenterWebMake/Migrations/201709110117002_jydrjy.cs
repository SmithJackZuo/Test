namespace CenterWebMake.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jydrjy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Labintroduces",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ContentText = c.String(nullable: false),
                        PublishDate = c.DateTime(nullable: false),
                        CreateUser = c.String(nullable: false, maxLength: 50),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Labintroduces");
        }
    }
}
