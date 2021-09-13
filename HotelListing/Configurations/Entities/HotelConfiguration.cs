using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
              new Hotel
              {
                  Id = 1,
                  Name = "Swiss Bell Hotel",
                  Address = "Jln.Tanjung Duren",
                  CountryId = 1,
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
    }
}
