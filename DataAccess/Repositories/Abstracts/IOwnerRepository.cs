using Core.Persistence.Repositories;
using Models.Dtos.ResponseDto.EmployeeResponses;
using Models.Dtos.ResponseDto.OwnerResponses;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts;

public interface IOwnerRepository:IEntityRepository<Owner,int>
{
    public List<OwnerDetailDto> GetAllOwnerDetails();
    public OwnerDetailDto GetDetailsById(int id);

}
