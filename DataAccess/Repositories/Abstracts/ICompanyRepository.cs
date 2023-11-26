using Core.Persistence.Repositories;
using Models.Dtos.ResponseDto.CompanyResponses;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts;

public interface ICompanyRepository:IEntityRepository<Company, int>
{
    public CompanyDetailDto GetById(int id);
    public List<CompanyDetailDto> GetAllCompanyDetails();
    public List<CompanyDetailDto> GetDetailsByOwnerId(int ownerId);
    public List<CompanyDetailDto> GetDetailsByCompanyName(string companyName);

}
