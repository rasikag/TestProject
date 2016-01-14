namespace TestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class palce_image_db_change : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlaceImagePlaces", "PlaceImage_Id", "dbo.PlaceImages");
            DropForeignKey("dbo.PlaceImagePlaces", "Place_Id", "dbo.Places");
            DropIndex("dbo.PlaceImagePlaces", new[] { "PlaceImage_Id" });
            DropIndex("dbo.PlaceImagePlaces", new[] { "Place_Id" });
            AddColumn("dbo.PlaceImages", "PlaceId", c => c.Guid(nullable: false));
            CreateIndex("dbo.PlaceImages", "PlaceId");
            AddForeignKey("dbo.PlaceImages", "PlaceId", "dbo.Places", "Id", cascadeDelete: true);
            DropTable("dbo.PlaceImagePlaces");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PlaceImagePlaces",
                c => new
                    {
                        PlaceImage_Id = c.Guid(nullable: false),
                        Place_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlaceImage_Id, t.Place_Id });
            
            DropForeignKey("dbo.PlaceImages", "PlaceId", "dbo.Places");
            DropIndex("dbo.PlaceImages", new[] { "PlaceId" });
            DropColumn("dbo.PlaceImages", "PlaceId");
            CreateIndex("dbo.PlaceImagePlaces", "Place_Id");
            CreateIndex("dbo.PlaceImagePlaces", "PlaceImage_Id");
            AddForeignKey("dbo.PlaceImagePlaces", "Place_Id", "dbo.Places", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PlaceImagePlaces", "PlaceImage_Id", "dbo.PlaceImages", "Id", cascadeDelete: true);
        }
    }
}
