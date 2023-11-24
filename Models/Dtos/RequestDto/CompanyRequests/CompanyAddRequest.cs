using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.RequestDto.CompanyRequests;

public record class CompanyAddRequest(string companyName, int ownerId)
{
    public static Company ConvertToEntity(CompanyAddRequest request)
    {
        return new Company
        {
            Name = request.companyName,
            OwnerId = request.ownerId

        };
    }

}
