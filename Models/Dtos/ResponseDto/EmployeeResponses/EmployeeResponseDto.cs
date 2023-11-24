using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.ResponseDto.EmployeeResponses;

public record EmployeeResponseDto (Guid employeeId, string employeeName, decimal employeeSalary, int employeeCompanyId )
{
    public static implicit operator EmployeeResponseDto(Employee employee)
    {
        return new EmployeeResponseDto(
            employeeId:employee.Id,
            employeeName:employee.Name,
            employeeSalary:employee.Salary,
            employeeCompanyId:employee.CompanyId

            );
    }

}
