using Core.Persistence.EntityBaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;

public  class Employee:Entity<Guid>
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public Company Company { get; set; }
    public int CompanyId { get; set; }


}
