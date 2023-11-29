
using Azure.Core;
using Core.Shared;
using DataAccess.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos.RequestDto.CompanyRequests;
using Models.Dtos.ResponseDto.CompanyResponses;
using Models.Dtos.ResponseDto.OwnerResponses;
using Models.Entities;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete;

public class CompanyService : ICompanyService
{
    private readonly ICompanyRepository _companyRepository;

    public CompanyService(ICompanyRepository companyRepository)
    {
        _companyRepository = companyRepository;
    }

    public Response<CompanyResponseDto> Add(CompanyAddRequest request)
    {
        try
        {


            Company company = CompanyAddRequest.ConvertToEntity(request);

            _companyRepository.Add(company);

             var response = CompanyResponseDto.ConvertToResponse(company);


            return new Response<CompanyResponseDto>
            {
                Data = response,
                Message = "Şirket Eklendi",
                StatusCode = System.Net.HttpStatusCode.Created
            };
        }
        catch(Exception ex)
        {
            return new Response<CompanyResponseDto>()
            {
                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }
    }

    public Response<CompanyResponseDto> Delete([FromQuery] int id)
    {
        try
        {



            var company = _companyRepository.GetById(id);
            _companyRepository.Delete(company);
            var response=  CompanyResponseDto.ConvertToResponse(company);


            return new Response<CompanyResponseDto>
            {
                Data = response,
                Message = "Şirket Başarıyla Silindi",
                StatusCode = System.Net.HttpStatusCode.Created
            };
        }
        catch (Exception ex)
        {
            return new Response<CompanyResponseDto>()
            {
                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }
    }

    public Response<List<CompanyResponseDto>> GetAll()
    {
        var companies = _companyRepository.GetAll();
        var response = companies.Select(x=> CompanyResponseDto.ConvertToResponse(x)).ToList(); ;
        return new Response<List<CompanyResponseDto>>()
        {
            Message = $"{response.Count()} adet şirket gösteriliyor. ",
            Data = response,
            StatusCode = System.Net.HttpStatusCode.OK
        };
    }

    public Response<CompanyResponseDto> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Response<CompanyResponseDto> Update(CompanyUpdateRequest companyUpdateRequest)
    {
        throw new NotImplementedException();
    }
}
