using DataAccess.Context;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace DataAccess;
public static class DataAccessDependencies
{
    public static IServiceCollection AddDataAccessDependencies(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddScoped<ICompanyRepository, CompanyRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IShipRepository, ShipRepository>();
        services.AddScoped<IOwnerRepository, OwnerRepository>();
       
           

        services.AddDbContext<BaseDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("SqlConnection"), b => b.MigrationsAssembly("WebAPI")));



        return services;
    }

}
