using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.RequestDto.EmployeeRequests;

public record EmployeeAddRequest(string employeeName, decimal employeeSalary, int CompanyId)
{
    public static Employee ConvertToEntity(EmployeeAddRequest request)
    {
        return new Employee()
        {
            Name = request.employeeName,
            Salary = request.employeeSalary,
            CompanyId = request.CompanyId
        };
}
}
