using Core.Persistence.Repositories;
using Models.Dtos.ResponseDto.CompanyResponses;
using Models.Dtos.ResponseDto.EmployeeResponses;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts;

public interface IEmployeeRepository:IEntityRepository<Employee,Guid>
{
    public List<EmployeeDetailDto> GetAllEmployeeDetails();
    public List<EmployeeDetailDto> GetDetailsByCompanyId(int id);
    public EmployeeDetailDto GetDetailsById(Guid id);
    public List<EmployeeDetailDto> GetDetailsByEmployeeName(string companyName);
}
