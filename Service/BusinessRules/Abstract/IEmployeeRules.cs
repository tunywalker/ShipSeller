using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessRules.Abstract;

public interface IEmployeeRules
{
    
    void EmployeeIsPresent(Guid id);
    void EmployeeSalaryMoreThanZero(double salary);
    void CheckEmployeeName(string employeeName);

}
