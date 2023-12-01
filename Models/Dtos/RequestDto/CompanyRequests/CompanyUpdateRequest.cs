using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Models.Dtos.RequestDto.CompanyRequests;

public record CompanyUpdateRequest(int Id, string companyName,int ownerId)
{
   
    public static Company ConvertToEntity(CompanyUpdateRequest request)
    {
        return new Company
        {
            Id = request.Id,
            Name = request.companyName,
            CompanyOwnerId = request.ownerId
            

        };
    }
}
