using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessRules.Abstract;

public interface IOwnerRules
{
    void OwnerNameMustBeUnique(string ownerName);
    void OwnerIsPresent(int id);
}
