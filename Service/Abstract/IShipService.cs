using Core.Shared;
using Models.Dtos.RequestDto.OwnerRequests;
using Models.Dtos.RequestDto.ShipRequests;
using Models.Dtos.ResponseDto.OwnerResponses;
using Models.Dtos.ResponseDto.ShipResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract;

public interface IShipService
{

    Response<ShipResponseDto> Add(ShipAddRequest request);
    Response<ShipResponseDto> Update(ShipUpdateRequest request);
    Response<ShipResponseDto> Delete(int id);

    Response<ShipResponseDto> GetById(int id);
    Response<List<ShipResponseDto>> GetAll();
}
