namespace CenterWebMake.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dfhrh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Labintroduces", "Title", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Labintroduces", "Title");
        }
    }
}
