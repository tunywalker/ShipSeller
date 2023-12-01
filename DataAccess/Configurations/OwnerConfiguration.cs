using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations;

public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
{


    public void Configure(EntityTypeBuilder<Owner> builder)
    {
        builder.HasData(
           new Owner() { Id = 1, Name = "Tuna GÜL" },
           new Owner() { Id = 2, Name = "Zatoichi Kiroshi" },
           new Owner() { Id = 3, Name = "Raquel Sanchez" },
           new Owner() { Id = 4, Name = "Emilio Zanetti" }
            );
    }
}
