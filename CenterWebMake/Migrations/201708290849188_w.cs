namespace CenterWebMake.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class w : DbMigration
    {
        public override void Up()
        {
            
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Login");
            DropTable("dbo.CenterNewsCreate");
        }
    }
}
