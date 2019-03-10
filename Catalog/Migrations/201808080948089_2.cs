namespace Catalog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Seed", c => c.String());
            DropColumn("dbo.Students", "Secret");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Secret", c => c.String());
            DropColumn("dbo.Students", "Seed");
        }
    }
}
