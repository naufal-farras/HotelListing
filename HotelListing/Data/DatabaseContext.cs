using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        //ctor
        public DatabaseContext(DbContextOptions options) : base(options)
        {}


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                  new Country
                  {
                      Id = 2,
                      Name = "Bahmas",
                      ShortName = "BS"
                  },
                    new Country
                    {
                        Id = 3,
                        Name = "Caymand Island",
                        ShortName = "CI"
                    }
                );
            builder.Entity<Hotel>().HasData(
               new Hotel
               {
                   Id = 1,
                   Name = "Swiss Bell Hotel",
                   Address = "Jln.Tanjung Duren",
                   CountryId= 1,
                   Ratting = 4.5
               },
                 new Hotel
                 {
                     Id = 2,
                     Name = "Metta Stars Hotel",
                     Address = "Jln.Kemana Saja",
                        CountryId = 2,
                     Ratting = 3.5

                 },
                   new Hotel
                   {
                       Id = 3,
                       Name = "Rich Hotel",
                       Address = "Jln.Apel 2",
                       CountryId = 3,
                       Ratting = 4

                   }
                   );
        }

        public DbSet<Country> Countries{ get; set; }
        public DbSet<Hotel> Hotels{ get; set; }


    }
}
