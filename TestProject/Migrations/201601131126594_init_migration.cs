namespace TestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DistrictName = c.String(maxLength: 25, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EventComments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EventId = c.Guid(nullable: false),
                        Approved = c.Boolean(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .Index(t => t.EventId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 25, unicode: false),
                        City = c.String(maxLength: 25, unicode: false),
                        Address = c.String(maxLength: 250, unicode: false),
                        EventStartTime = c.DateTime(nullable: false),
                        EventEndTime = c.DateTime(nullable: false),
                        Description = c.String(storeType: "ntext"),
                        DistrictId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Districts", t => t.DistrictId, cascadeDelete: true)
                .Index(t => t.DistrictId);
            
            CreateTable(
                "dbo.EventImages",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EventId = c.Guid(nullable: false),
                        Approved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .Index(t => t.EventId);
            
            CreateTable(
                "dbo.EventVideos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EventId = c.Guid(nullable: false),
                        Approved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .Index(t => t.EventId);
            
            CreateTable(
                "dbo.PlaceComments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PlaceId = c.Guid(nullable: false),
                        Approved = c.Boolean(nullable: false),
                        Comment = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Places", t => t.PlaceId, cascadeDelete: true)
                .Index(t => t.PlaceId);
            
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PlaceName = c.String(),
                        PlaceLocatedCity = c.String(),
                        Address = c.String(),
                        PlaceOpenTime = c.DateTime(nullable: false),
                        PlaceCloseTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        DistrictId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Districts", t => t.DistrictId, cascadeDelete: true)
                .Index(t => t.DistrictId);
            
            CreateTable(
                "dbo.PlaceImages",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Approved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlaceVideos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PlaceId = c.Guid(nullable: false),
                        Approved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Places", t => t.PlaceId, cascadeDelete: true)
                .Index(t => t.PlaceId);
            
            CreateTable(
                "dbo.PlaceImagePlaces",
                c => new
                    {
                        PlaceImage_Id = c.Guid(nullable: false),
                        Place_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlaceImage_Id, t.Place_Id })
                .ForeignKey("dbo.PlaceImages", t => t.PlaceImage_Id, cascadeDelete: true)
                .ForeignKey("dbo.Places", t => t.Place_Id, cascadeDelete: true)
                .Index(t => t.PlaceImage_Id)
                .Index(t => t.Place_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlaceComments", "PlaceId", "dbo.Places");
            DropForeignKey("dbo.PlaceVideos", "PlaceId", "dbo.Places");
            DropForeignKey("dbo.PlaceImagePlaces", "Place_Id", "dbo.Places");
            DropForeignKey("dbo.PlaceImagePlaces", "PlaceImage_Id", "dbo.PlaceImages");
            DropForeignKey("dbo.Places", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.EventComments", "EventId", "dbo.Events");
            DropForeignKey("dbo.EventVideos", "EventId", "dbo.Events");
            DropForeignKey("dbo.EventImages", "EventId", "dbo.Events");
            DropForeignKey("dbo.Events", "DistrictId", "dbo.Districts");
            DropIndex("dbo.PlaceImagePlaces", new[] { "Place_Id" });
            DropIndex("dbo.PlaceImagePlaces", new[] { "PlaceImage_Id" });
            DropIndex("dbo.PlaceVideos", new[] { "PlaceId" });
            DropIndex("dbo.Places", new[] { "DistrictId" });
            DropIndex("dbo.PlaceComments", new[] { "PlaceId" });
            DropIndex("dbo.EventVideos", new[] { "EventId" });
            DropIndex("dbo.EventImages", new[] { "EventId" });
            DropIndex("dbo.Events", new[] { "DistrictId" });
            DropIndex("dbo.EventComments", new[] { "EventId" });
            DropTable("dbo.PlaceImagePlaces");
            DropTable("dbo.PlaceVideos");
            DropTable("dbo.PlaceImages");
            DropTable("dbo.Places");
            DropTable("dbo.PlaceComments");
            DropTable("dbo.EventVideos");
            DropTable("dbo.EventImages");
            DropTable("dbo.Events");
            DropTable("dbo.EventComments");
            DropTable("dbo.Districts");
        }
    }
}
