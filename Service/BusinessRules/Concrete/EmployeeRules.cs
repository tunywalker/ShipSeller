using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Repositories.Abstracts;
using Service.BusinessRules.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessRules.Concrete;

public class EmployeeRules : IEmployeeRules
{
    IEmployeeRepository _employeeRepository;

    public EmployeeRules(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public void CheckEmployeeName(string employeeName)
    {
        if (employeeName.Length < 6)
            throw new BusinessException($"Çalışan ismi en az 5 karakter olmalı.'{employeeName}' : '{employeeName}' karakter. ");
        if (employeeName.Length == 0)
            throw new BusinessException($"Çalışan ismi boş bırakılamaz.");

    }

    public void EmployeeIsPresent(Guid id)
    {
        var employee = _employeeRepository.GetById(id);
        if (employee == null)
            throw new BusinessException($"Id:{id} olan çalışan bulunamadı.");
    }

   

    public void EmployeeSalaryMoreThanZero(double salary)
    {
        if(salary<=0)
            throw new BusinessException($"Çalışan maaşı 0 dan büyük olmalı.");
    }
}
