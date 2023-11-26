using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.ResponseDto.CompanyResponses
{
    public record CompanyDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public int? OwnerId { get; set; }
        public List<Employee> Employees { get; set; }

    }
}
