using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context;

public class BaseDbContext : DbContext
{

    public BaseDbContext(DbContextOptions<BaseDbContext> opt) : base(opt)
    {

    }


    public DbSet<Company> Companies { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Ship> Ships { get; set; }


}
