using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.ResponseDto.ShipResponses
{
    public record ShipResponseDto(int shipId, string shipName, double shipLength, int shipAuthorCompanyId, ShipColor shipColor)
    {

        public static implicit operator ShipResponseDto(Ship ship)
        {
            return new ShipResponseDto(
                shipId:ship.Id,
                shipName:ship.Name,
                shipLength:ship.Length,
                shipColor:ship.ShipColor,
                shipAuthorCompanyId :ship.AuthorCompanyId

                
                );
        }
    }
}
