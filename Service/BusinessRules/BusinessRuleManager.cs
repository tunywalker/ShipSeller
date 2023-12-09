using Service.BusinessRules.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessRules;

internal class BusinessRuleManager:IBusinessRuleManager
{
    private readonly ICompanyRules _companyRules;
    private readonly IOwnerRules _ownerRules;
    private readonly IEmployeeRules _employeeRules;

    public BusinessRuleManager(ICompanyRules companyRules, IOwnerRules ownerRules, IEmployeeRules employeeRules)
    {
        _companyRules = companyRules;
        _ownerRules = ownerRules;
        _employeeRules = employeeRules;
    }
    public ICompanyRules CompanyRules  => _companyRules;
    public IOwnerRules OwnerRules => _ownerRules;

    public IEmployeeRules EmployeeRules => _employeeRules;
}
