using Core.Shared;
using Models.Dtos.RequestDto.CompanyRequests;
using Models.Dtos.RequestDto.OwnerRequests;
using Models.Dtos.ResponseDto.OwnerResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract;

public interface IOwnerService
{
    Response<OwnerResponseDto> Add(OwnerAddRequest request);
    Response<OwnerResponseDto> Update(OwnerUpdateRequest request);
    Response<OwnerResponseDto> Delete(int id);

    Response<OwnerResponseDto> GetById(int id);
    Response<List<OwnerDetailDto>> GetAll();
}
