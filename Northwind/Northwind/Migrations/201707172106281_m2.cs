namespace Northwind.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registers", "employeeID", c => c.Int(nullable: false));
            DropColumn("dbo.Registers", "error");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Registers", "error", c => c.Boolean(nullable: false));
            DropColumn("dbo.Registers", "employeeID");
        }
    }
}
