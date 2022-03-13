using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    // pac - 
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country { CountryId = 1, Name = "India", ShortName = "IND" },
                new Country { CountryId = 2, Name = "United States", ShortName = "USA" },
                new Country { CountryId = 3, Name = "Canada", ShortName = "CAN" },
                new Country { CountryId = 4, Name = "Italy", ShortName = "ITL" }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel { Id = 11, Name = "Indian Hotel", Address = "Phase-11 India", Rating = 5, CountryId = 1 },
                new Hotel { Id = 15, Name = "Indian Hotel-2", Address = "Phase-11 India", Rating = 5, CountryId = 1 },
                new Hotel { Id = 12, Name = "United Hotel", Address = "Phase-12 United", Rating = 5, CountryId = 2 },
                new Hotel { Id = 13, Name = "Canada Hotel", Address = "Phase-13 Canada", Rating = 5, CountryId = 3 },
                new Hotel { Id = 14, Name = "Italy Hotel", Address = "Phase-14 Italy", Rating = 5, CountryId = 4 }
                );
        }
    }
}
