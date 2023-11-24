using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.RequestDto.OwnerRequests;

public record OwnerAddRequest(string ownerName)
{
    public static Owner ConvertToEntity(OwnerAddRequest request)
    {
        return new Owner
        {
            Name = request.ownerName,
        };
    }
}
