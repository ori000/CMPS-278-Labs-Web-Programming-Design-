using lab_10_finale_ori00.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace lab_10_finale_ori00.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        public DbSet<Hotel> Hotel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { id = 1, name = "Hotel_1", rooms = 100, location = "Berlin", description = "D1", phone = "1921", rating = 4, imgURL = "https://content.r9cdn.net/res/images/horizon/ui/seoCommon/destinationtiles/seo_hotels.jpg?v=aeb8c67f83d5b9fd53ca97055fc8402800bf3ce4&cluster=4" },
                new Hotel { id = 2, name = "Hotel_2", rooms = 200, location = "Moscow", description = "D2", phone = "2121", rating = 5, imgURL = "https://content.r9cdn.net/res/images/horizon/ui/seoCommon/destinationtiles/seo_hotels.jpg?v=aeb8c67f83d5b9fd53ca97055fc8402800bf3ce4&cluster=4" },
                new Hotel { id = 3, name = "Hotel_3", rooms = 220, location = "Athens", description = "D3", phone = "3221", rating = 5, imgURL = "https://content.r9cdn.net/res/images/horizon/ui/seoCommon/destinationtiles/seo_hotels.jpg?v=aeb8c67f83d5b9fd53ca97055fc8402800bf3ce4&cluster=4" },
                new Hotel { id = 4, name = "Hotel_4", rooms = 420, location = "Bucharest", description = "D4", phone = "2221", rating = 5, imgURL = "https://content.r9cdn.net/res/images/horizon/ui/seoCommon/destinationtiles/seo_hotels.jpg?v=aeb8c67f83d5b9fd53ca97055fc8402800bf3ce4&cluster=4" }
                );
        }
    }
}
