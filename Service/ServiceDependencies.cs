using Microsoft.Extensions.DependencyInjection;
using Service.Abstract;
using Service.BusinessRules;
using Service.BusinessRules.Abstract;
using Service.BusinessRules.Concrete;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service;

public static class ServiceDependencies
{
    public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
    {
        services.AddScoped<ICompanyService,CompanyService>();
        services.AddScoped<IOwnerRules,OwnerRules>();
        services.AddScoped<ICompanyRules, CompanyRules>();

        services.AddScoped<IBusinessRuleManager, BusinessRuleManager>();

        return services;


    }
}
