using Core.Shared;
using Models.Dtos.RequestDto.CompanyRequests;
using Models.Dtos.ResponseDto.CompanyResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract;

public interface ICompanyService
{
    Response<CompanyResponseDto> Add(CompanyAddRequest companyAddRequest);
    Response<CompanyResponseDto> Update(CompanyUpdateRequest companyUpdateRequest);
    Response<CompanyResponseDto> Delete(int id);

    Response<CompanyResponseDto> GetById(int id);
    Response<List<CompanyResponseDto>> GetAll();
    Response<List<CompanyDetailDto>> GetDetailsByCompanyName(string categoryName);
    Response<List<CompanyDetailDto>> GetAllCompanyDetails();

    


}
