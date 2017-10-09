namespace CenterWebMake.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class r : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AchievementShows",
                c => new
                    {
                        Title = c.String(nullable: false, maxLength: 50),
                        ContentText = c.String(nullable: false),
                        IsPublich = c.Boolean(nullable: false),
                        PublishDate = c.DateTime(nullable: false),
                        CreateUser = c.String(nullable: false, maxLength: 50),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AchievementShows");
        }
    }
}
