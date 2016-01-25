namespace TestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_codinates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Places", "Longitude", c => c.Double(nullable: false));
            AddColumn("dbo.Places", "Latitude", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Places", "Latitude");
            DropColumn("dbo.Places", "Longitude");
        }
    }
}
