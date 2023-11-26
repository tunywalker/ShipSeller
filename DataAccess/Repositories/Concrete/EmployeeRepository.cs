using Core.Persistence.Repositories;
using DataAccess.Context;
using DataAccess.Repositories.Abstracts;
using Models.Dtos.ResponseDto.EmployeeResponses;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete;

public class EmployeeRepository : EfRepositoryBase<BaseDbContext, Employee, Guid>, IEmployeeRepository
{
    public EmployeeRepository(BaseDbContext context) : base(context)
    {

    }

    public List<EmployeeDetailDto> GetDetailsByCompanyId(int companyId)
    {
        var details = Context.Employees.Where(e => e.Id.Equals(companyId)).Join(
           Context.Companies,
           e => e.Id.ToString(),
           c => c.Id.ToString(),
           (employee, company) => new EmployeeDetailDto
           {
               Id = employee.Id,
               CompanyName = company.Name,
               Name = employee.Name,
               Salary = employee.Salary
           }
       ).ToList();

        return details;
    }

    public List<EmployeeDetailDto> GetDetailsByEmployeeName(string employeeName)
    {
        var details = Context.Employees.Where(e=>e.Name.Contains(employeeName)).Join(
             Context.Companies,
             e => e.Id.ToString(),
             c => c.Id.ToString(),
             (employee, company) => new EmployeeDetailDto
             {
                 Id = employee.Id,
                 CompanyName = company.Name,
                 Name = employee.Name,
                 Salary = employee.Salary
             }
         ).ToList();

        return details;
    }

    public EmployeeDetailDto GetDetailsById(Guid id)
    {
        var details = Context.Employees.Where(e=>e.Id.Equals(id)).Join(
             Context.Companies,
             e => e.Id.ToString(),
             c => c.Id.ToString(),
             (employee, company) => new EmployeeDetailDto
             {
                 Id = employee.Id,
                 CompanyName = company.Name,
                 Name = employee.Name,
                 Salary = employee.Salary
             }
         ).SingleOrDefault();

        return details;
    }

    List<EmployeeDetailDto> IEmployeeRepository.GetAllEmployeeDetails()
    {
        var details = Context.Employees.Join(
            Context.Companies,
            e => e.Id.ToString(), 
            c => c.Id.ToString(), 
            (employee, company) => new EmployeeDetailDto
            {
                Id = employee.Id,
                CompanyName = company.Name,
                Name = employee.Name,
                Salary = employee.Salary
            }
        ).ToList();

        return details;
    }

    List<EmployeeDetailDto> IEmployeeRepository.GetDetailsByCompanyId(int id)
    {
        throw new NotImplementedException();
    }
}
