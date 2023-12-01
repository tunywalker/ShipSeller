using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.ResponseDto.OwnerResponses;

public record OwnerReponseDto(int ownerId, string ownerName, List<Company> ownerCompanies)
{
    public static OwnerReponseDto ConvertToResponse(Owner owner)
    {
        return new OwnerReponseDto(
            ownerId:owner.Id,
            ownerName:owner.Name,
            ownerCompanies:owner.Companies
            );
    }
}
