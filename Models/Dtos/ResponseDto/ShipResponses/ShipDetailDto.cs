using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.ResponseDto.ShipResponses;

public record ShipDetailDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Length { get; set; }
    public Company AuthorCompany { get; set; }


    public ShipColor ShipColor { get; set; }
}
