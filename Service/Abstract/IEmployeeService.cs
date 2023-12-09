using Core.Shared;
using Models.Dtos.RequestDto.EmployeeRequests;
using Models.Dtos.RequestDto.OwnerRequests;
using Models.Dtos.ResponseDto.EmployeeResponses;
using Models.Dtos.ResponseDto.OwnerResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract;

public interface IEmployeeService
{
    Response<EmployeeResponseDto> Add(EmployeeAddRequest request);
    Response<EmployeeResponseDto> Update(EmployeeUpdateRequest request);
    Response<EmployeeResponseDto> Delete(Guid id);

    Response<EmployeeResponseDto> GetById(Guid id);
    Response<List<EmployeeResponseDto>> GetAll();
}
