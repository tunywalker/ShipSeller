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
    public Owner? Owner { get; set; }
    public int Id { get; set; }
    public List<Employee> Employees { get; set; }

}
