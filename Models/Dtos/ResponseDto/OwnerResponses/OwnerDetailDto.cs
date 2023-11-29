using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.ResponseDto.OwnerResponses;

public record OwnerDetailDto
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Company> Companies { get; set; }
}
