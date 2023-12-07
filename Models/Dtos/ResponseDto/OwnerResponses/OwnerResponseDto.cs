using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.ResponseDto.OwnerResponses;

public record OwnerResponseDto(int ownerId, string ownerName, List<Company> ownerCompanies)
{
    public static OwnerResponseDto ConvertToResponse(Owner owner)
    {
        return new OwnerResponseDto(
            ownerId:owner.Id,
            ownerName:owner.Name,
            ownerCompanies:owner.Companies
            );
    }
}
