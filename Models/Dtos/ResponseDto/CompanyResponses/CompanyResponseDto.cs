using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.Dtos.ResponseDto.OwnerResponses;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.ResponseDto.CompanyResponses;

public record CompanyResponseDto(int companyId, string companyName, int? companyOwnerId)
{

    
    public static CompanyResponseDto ConvertToResponse(Company company)
    {
        return new CompanyResponseDto(
            companyId: company.Id,
            companyName: company.Name,
            companyOwnerId: company.CompanyOwnerId
            ); 


    }



}
