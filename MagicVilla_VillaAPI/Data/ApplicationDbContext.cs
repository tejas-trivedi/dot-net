using Microsoft.EntityFrameworkCore;
using MagicVilla_VillaAPI.Model;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Lorem ipsum",
                    ImageUrl = "",
                    Occupancy = "5", 
                    Rate= 200, 
                    Sqft = 550, 
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 2,
                    Name = "Diamond Villa",
                    Details = "Lorem ipsum",
                    ImageUrl = "",
                    Occupancy = "5",
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                }, 
                new Villa
                {
                    Id = 3,
                    Name = "Royal Villa",
                    Details = "Lorem ipsum",
                    ImageUrl = "",
                    Occupancy = "5",
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                }, 
                new Villa
                {
                    Id = 4,
                    Name = "Diamond pool Villa",
                    Details = "Lorem ipsum",
                    ImageUrl = "",
                    Occupancy = "5",
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                }, 
                new Villa
                {
                    Id = 5,
                    Name = "Luxury Villa",
                    Details = "Lorem ipsum",
                    ImageUrl = "",
                    Occupancy = "5",
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 6,
                    Name = "Luxury pool Villa",
                    Details = "Lorem ipsum",
                    ImageUrl = "",
                    Occupancy = "5",
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 7,
                    Name = "Premium Villa",
                    Details = "Lorem ipsum",
                    ImageUrl = "",
                    Occupancy = "5",
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                }
                );
        }
    }
}
