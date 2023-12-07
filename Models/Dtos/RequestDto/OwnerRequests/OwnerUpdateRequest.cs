using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.RequestDto.OwnerRequests;

public record OwnerUpdateRequest(int ownerId, string ownerName)
{
    public static Owner ConvertToEntity(OwnerUpdateRequest request)
    {
        return new Owner
        {
            Id=request.ownerId,
            Name = request.ownerName,
            
        };
    }
}

