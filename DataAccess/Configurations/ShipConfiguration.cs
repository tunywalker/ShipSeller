using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations;

public class ShipConfiguration : IEntityTypeConfiguration<Ship>
{
    public void Configure(EntityTypeBuilder<Ship> builder)
    {
        builder.HasData(
            new Ship() { Id = 1, CompanyId = 1, Name = "Uçak Gemisi", Length = 50, ShipColor = ShipColor.Black },
            new Ship() { Id = 2, CompanyId = 1, Name = "Yük Gemisi", Length = 30, ShipColor = ShipColor.YellowGreen },
            new Ship() { Id = 3, CompanyId = 1, Name = "Buğday Gemisi", Length = 30, ShipColor = ShipColor.Yellow },
            new Ship() { Id = 4, CompanyId = 2, Name = "Oil Ship", Length = 40, ShipColor = ShipColor.Red },
            new Ship() { Id = 5, CompanyId = 2, Name = "Car Ship", Length = 30, ShipColor = ShipColor.Green },
            new Ship() { Id = 6, CompanyId = 2, Name = "Drone Ship", Length = 25, ShipColor = ShipColor.Green },
            new Ship() { Id = 7, CompanyId = 3, Name = "Fisher Boat", Length = 10, ShipColor = ShipColor.Red },
            new Ship() { Id = 8, CompanyId = 3, Name = "Mussell Hunter", Length = 5, ShipColor = ShipColor.Black }
            );
    }
}
