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

    public BusinessRuleManager(ICompanyRules companyRules, IOwnerRules ownerRules)
    {
        _companyRules = companyRules;
        _ownerRules = ownerRules;
    }
    public ICompanyRules CompanyRules  => _companyRules;
    public IOwnerRules OwnerRules => _ownerRules;
}
