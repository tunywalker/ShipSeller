using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasData(
            new Company() { Id = 1, Name = "Turkey Ship-Co", CompanyOwnerId = 1 },
            new Company() { Id = 2, Name = "Japan Ship-Co", CompanyOwnerId = 1 },
            new Company() { Id = 3, Name = "Monaco Ship-Co", CompanyOwnerId = 2 },
            new Company() { Id = 4, Name = "Spain Ship-Co", CompanyOwnerId = 3 },
            new Company() { Id = 5, Name = "Germany Ship-Co", CompanyOwnerId = 3 }
            );
    }


}
