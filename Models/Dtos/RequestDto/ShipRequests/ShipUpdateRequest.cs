using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.RequestDto.ShipRequests;

public record ShipUpdateRequest(int shipId, string shipName, double shipLenght, int shipAuthorCompanyId, ShipColor shipColor)
{
    public static Ship ConvertToEntity(ShipUpdateRequest request)
    {
        return new Ship()
        {
            Id = request.shipId,
            Name = request.shipName,
            Length = request.shipLenght,
            AuthorCompanyId = request.shipAuthorCompanyId,
            ShipColor = request.shipColor,

        };
    }

}

