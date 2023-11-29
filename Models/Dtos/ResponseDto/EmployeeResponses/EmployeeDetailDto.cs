using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.ResponseDto.EmployeeResponses
{
    public record EmployeeDetailDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string CompanyName { get; set; }
        

    }
}
