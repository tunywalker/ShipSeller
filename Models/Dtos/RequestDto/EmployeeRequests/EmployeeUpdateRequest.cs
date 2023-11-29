using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.RequestDto.EmployeeRequests;

public record EmployeeUpdateRequest(Guid employeeId, string employeeName, double employeeSalary, int CompanyId)
{
    public static Employee ConvertToEntity(EmployeeUpdateRequest request)
    {
        return new Employee()
        {
            Id=request.employeeId,
            Name = request.employeeName,
            Salary = request.employeeSalary,
            CompanyId = request.CompanyId
        };
    }
}
