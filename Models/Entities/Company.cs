using Core.Persistence.EntityBaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;

public class Company:Entity<int>
{
    public string Name { get; set; }
    public Owner? CompanyOwner { get; set; }
    public int? CompanyOwnerId { get; set; }
    public List<Employee>? CompanyEmployees { get; set; }

}
