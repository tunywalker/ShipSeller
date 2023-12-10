using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessRules.Abstract;

public  interface IBusinessRuleManager
{
    IOwnerRules OwnerRules { get; }
    ICompanyRules CompanyRules { get; }

    IEmployeeRules EmployeeRules { get; }

    IShipRules ShipRules { get; }
}
