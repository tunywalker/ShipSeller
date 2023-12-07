
using Azure.Core;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Shared;
using DataAccess.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos.RequestDto.CompanyRequests;
using Models.Dtos.ResponseDto.CompanyResponses;
using Models.Dtos.ResponseDto.OwnerResponses;
using Models.Entities;
using Service.Abstract;
using Service.BusinessRules.Abstract;
using Service.BusinessRules.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete;

public class CompanyService : ICompanyService
{
    private readonly ICompanyRepository _companyRepository;
    private readonly IBusinessRuleManager _ruleManager;

    public CompanyService(ICompanyRepository companyRepository, IBusinessRuleManager ruleManager)
    {
        _companyRepository = companyRepository;
        _ruleManager = ruleManager;
    }

    public Response<CompanyResponseDto> Add(CompanyAddRequest request)
    {
        try
        {


            Company company = CompanyAddRequest.ConvertToEntity(request);
            _ruleManager.CompanyRules.CompanyNameMustBeUnique(request.companyName);
            _ruleManager.OwnerRules.OwnerIsPresent(request.ownerId);
            _companyRepository.Add(company);

            var response = CompanyResponseDto.ConvertToResponse(company);


            return new Response<CompanyResponseDto>
            {
                Data = response,
                Message = "Şirket Eklendi",
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

    public Response<CompanyResponseDto> Delete([FromQuery] int id)
    {
        try
        {


            _ruleManager.CompanyRules.CompanyIsPresent(id);
            var company = _companyRepository.GetById(id);
            _companyRepository.Delete(company);
            var response = CompanyResponseDto.ConvertToResponse(company);


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
        var response = companies.Select(x => CompanyResponseDto.ConvertToResponse(x)).ToList(); 
        return new Response<List<CompanyResponseDto>>()
        {
            Message = $"{response.Count()} adet şirket gösteriliyor. ",
            Data = response,
            StatusCode = System.Net.HttpStatusCode.OK
        };
    }

    public Response<List<CompanyDetailDto>> GetAllCompanyDetails()
    {
        var companies = _companyRepository.GetAllCompanyDetails();

        return new Response<List<CompanyDetailDto>>()
        {
            Message = $"{companies.Count()} adet şirket gösteriliyor. ",
            Data = companies,
            StatusCode = System.Net.HttpStatusCode.OK
        };
    }

    public Response<CompanyResponseDto> GetById(int id)
    {

        try
        {
            _ruleManager.CompanyRules.CompanyIsPresent(id);
            var company = _companyRepository.GetById(id);

            var response = CompanyResponseDto.ConvertToResponse(company);
            return new Response<CompanyResponseDto>()
            {
                Data = response,
                Message = $"{response.companyName} isimli şirket bilgileri gösteriliyor.",
                StatusCode = System.Net.HttpStatusCode.OK


            };
        }

        catch (BusinessException ex)
        {
            return new Response<CompanyResponseDto>()
            {

                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest

            };
        }
    }

    public Response<List<CompanyDetailDto>> GetDetailsByCompanyName(string categoryName)
    {

        try
        {

            var companies = _companyRepository.GetDetailsByCompanyName(categoryName);

           
            return new Response<List<CompanyDetailDto>>()
            {
                Data = companies,
                Message = $"'{companies.Count}' Adet şirket bilgisi gösteriliyor.",
                StatusCode = System.Net.HttpStatusCode.OK


            };
        }

        catch (BusinessException ex)
        {
            return new Response<List<CompanyDetailDto>>()
            {

                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest

            };
        }
    }

    public Response<CompanyResponseDto> Update(CompanyUpdateRequest companyUpdateRequest)
    {
        try
        {
            //  _ruleManager.CompanyRules.CompanyIsPresent(companyUpdateRequest.Id);
            Company company = CompanyUpdateRequest.ConvertToEntity(companyUpdateRequest);

            _companyRepository.Update(company);

            //_ruleManager.CompanyRules.CompanyNameMustBeUnique(companyUpdateRequest.companyName);


            var response = CompanyResponseDto.ConvertToResponse(_companyRepository.GetById(companyUpdateRequest.Id));
            return new Response<CompanyResponseDto>()
            {
                Data = response,
                Message = "Ürün başarıyla güncellendi.",
                StatusCode = System.Net.HttpStatusCode.OK

            };
        }
        catch (BusinessException ex)
        {
            return new Response<CompanyResponseDto>()
            {

                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest

            };
        }
    }


}
