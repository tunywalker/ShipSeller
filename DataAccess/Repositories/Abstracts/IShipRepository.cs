using Core.Persistence.Repositories;
using Models.Dtos.ResponseDto.EmployeeResponses;
using Models.Dtos.ResponseDto.ShipResponses;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts;

public interface IShipRepository:IEntityRepository<Ship,int>
{

    public List<ShipDetailDto> GetAllShipDetails();
    public ShipDetailDto GetDetailsByShipId(int shipId);
    public List<ShipDetailDto> GetDetailsByLength(decimal shiplength);
    public List<ShipDetailDto> GetDetailsByAuthorCompanyId(int id);
    public List<ShipDetailDto> GetByColor(ShipColor shipColor);

   

}
