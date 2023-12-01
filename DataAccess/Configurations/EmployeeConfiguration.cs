using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasData(
           new Employee() { Id = Guid.NewGuid(), CompanyId = 1, Name = "Hakkı Usta", Salary = 15000 },
           new Employee() { Id = Guid.NewGuid(), CompanyId = 1, Name = "Suat Usta", Salary = 20000 },
           new Employee() { Id = Guid.NewGuid(), CompanyId = 1, Name = "Ahmet Usta", Salary = 5000 },
           new Employee() { Id = Guid.NewGuid(), CompanyId = 2, Name = "Hitachi Usta", Salary = 25000 },
           new Employee() { Id = Guid.NewGuid(), CompanyId = 2, Name = "Makita Usta", Salary = 30000 },
           new Employee() { Id = Guid.NewGuid(), CompanyId = 2, Name = "Ryobi Usta", Salary = 45000 },
           new Employee() { Id = Guid.NewGuid(), CompanyId = 3, Name = "Buffon Usta", Salary = 20000 },
           new Employee() { Id = Guid.NewGuid(), CompanyId = 3, Name = "Hans Usta", Salary = 22000 },
           new Employee() { Id = Guid.NewGuid(), CompanyId = 3, Name = "Tsubasa Usta", Salary = 23232 },
           new Employee() { Id = Guid.NewGuid(), CompanyId = 3, Name = "Nail Usta", Salary = 33000 },
           new Employee() { Id = Guid.NewGuid(), CompanyId = 4, Name = "Iglesias Usta", Salary = 60000 }
           );

    }
}
