using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessRules.Abstract;

public interface ICompanyRules
{
    void CompanyNameMustBeUnique(string companyName);
    void CompanyIsPresent(int id);
}
