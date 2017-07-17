namespace Northwind.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m0 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Logins", newName: "Registers");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Registers", newName: "Logins");
        }
    }
}
