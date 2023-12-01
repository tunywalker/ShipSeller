using Core.Persistence.Repositories;
using DataAccess.Context;
using DataAccess.Repositories.Abstracts;
using Models.Dtos.ResponseDto.CompanyResponses;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete;

public class CompanyRepository : EfRepositoryBase<BaseDbContext, Company, int>, ICompanyRepository
{
    public CompanyRepository(BaseDbContext context) : base(context)
    {

    }
    public List<CompanyDetailDto> GetAllCompanyDetails()
    {
        var details = Context.Companies.Join(
            Context.Owners,
            c => c.Id,
            o => o.Id,
            (company, owner) => new CompanyDetailDto
            {
                Id = company.Id,
                Name = company.Name,
                OwnerId= owner.Id,
                OwnerName = owner.Name,
                Employees = company.CompanyEmployees,


            }).ToList();
        return details;
       
    }
    public List<CompanyDetailDto> GetDetailsByOwnerId(int ownerId)
    {
        var details = Context.Companies.Where(x=>x.Id.Equals(ownerId)).Join(
            Context.Owners,
            c => c.Id,
            o => o.Id,
            (company, owner) => new CompanyDetailDto
            {
                Id = company.Id,
                Name = company.Name,
                OwnerName = owner.Name,
                Employees = company.CompanyEmployees,


            }).ToList();
        return details;

    }


    public List<CompanyDetailDto> GetDetailsByCompanyName(string companyName)
    {
        var details = Context.Companies.Where(x => x.Name.Contains(companyName)).Join(
            Context.Owners,
            c => c.Id,
            o => o.Id,
            (company, owner) => new CompanyDetailDto
            {
                Id = company.Id,
                Name = company.Name,
                OwnerName = owner.Name,
                Employees = company.CompanyEmployees,


            }).ToList();
        return details;

    }
    
    public CompanyDetailDto GetById(int id)
    {

        var details = Context.Companies.Join(
            Context.Owners,
            c => c.Id,
            o => o.Id,
            (company, owner) => new CompanyDetailDto
            {
                Id = company.Id,
                Name = company.Name,
                OwnerName = owner.Name,
                Employees = company.CompanyEmployees,


            }).SingleOrDefault(x => x.Id == id);
        return details;
    }

   
}
