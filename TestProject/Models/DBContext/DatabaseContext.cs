using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestProject.Models.DBModels;

namespace TestProject.Models.DBContext
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext() : base("TravelConnection")
        {

        }

        public DbSet<District> Districts { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Event> Eventss { get; set; }
        public DbSet<PlaceImage> PlaceImages { get; set; }
        public DbSet<PlaceVideo> PlaceVideos { get; set; }
        public DbSet<PlaceComment> PlaceCommens { get; set; }
        public DbSet<EventImage> EventImages { get; set; }
        public DbSet<EventVideo> EventVideos { get; set; }
        public DbSet<EventComment> EventComments { get; set; }
    }
}