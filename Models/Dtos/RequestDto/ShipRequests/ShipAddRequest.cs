using Models.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.RequestDto.ShipRequests;

public record ShipAddRequest(string shipName, double shipLenght, int shipAuthorCompanyId, ShipColor shipColor)
{
    public static Ship ConvertToEntity(ShipAddRequest request)
    {
        return new Ship()
        {
            Name = request.shipName,
            Length = request.shipLenght,
            CompanyId = request.shipAuthorCompanyId,
            ShipColor = request.shipColor,

        };
    }

}
