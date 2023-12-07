
using Core.CrossCuttingConcerns.Exceptions;
using Core.Shared;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Concrete;
using Models.Dtos.RequestDto.CompanyRequests;
using Models.Dtos.RequestDto.OwnerRequests;
using Models.Dtos.ResponseDto.CompanyResponses;
using Models.Dtos.ResponseDto.OwnerResponses;
using Models.Entities;
using Service.Abstract;
using Service.BusinessRules.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete;

public class OwnerService : IOwnerService
{
    private readonly IOwnerRepository _ownerRepository;
    private readonly IBusinessRuleManager _ruleManager;

    public OwnerService(IOwnerRepository ownerRepository, IBusinessRuleManager businessRuleManager)
    {
        _ownerRepository = ownerRepository;
        _ruleManager = businessRuleManager;
    }

    public Response<OwnerResponseDto> Add(OwnerAddRequest ownerAddRequest)
    {
        try
        {
            Owner owner = OwnerAddRequest.ConvertToEntity(ownerAddRequest);
            _ruleManager.OwnerRules.OwnerNameMustBeUnique(ownerAddRequest.ownerName);
            _ownerRepository.Add(owner);
            var response = OwnerResponseDto.ConvertToResponse(owner);
            return new Response<OwnerResponseDto>
            {
                Data = response,
                Message = "Owner Eklendi",
                StatusCode = System.Net.HttpStatusCode.Created
            };
        }
        
        
        catch (Exception ex)
        {

            return new Response<OwnerResponseDto>
            {
                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }
        
    }

    public Response<OwnerResponseDto> Delete(int id)
    {
        try
        {
            _ruleManager.OwnerRules.OwnerIsPresent(id);
            Owner owner = _ownerRepository.GetById(id);
           
            _ownerRepository.Delete(owner);
            var response = OwnerResponseDto.ConvertToResponse(owner);
            return new Response<OwnerResponseDto>
            {
                Data = response,
                Message = "Owner Silindi",
                StatusCode = System.Net.HttpStatusCode.Created
            };
        }


        catch (Exception ex)
        {

            return new Response<OwnerResponseDto>
            {
                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }
    }

    public Response<List<OwnerDetailDto>> GetAll()
    {
        try
        {
            

           
            var Owners = _ownerRepository.GetAllOwnerDetails();
            
            return new Response<List<OwnerDetailDto>>
            {
                Data = Owners,
                Message = "Ownerlar listeleniyor",
                StatusCode = System.Net.HttpStatusCode.Created
            };
        }


        catch (Exception ex)
        {

            return new Response<List<OwnerDetailDto>>
            {
                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }
    }

    public Response<OwnerResponseDto> GetById(int id)
    {
        try
        {
            
            _ruleManager.OwnerRules.OwnerIsPresent(id);
            Owner owner = _ownerRepository.GetById(id);
            var response = OwnerResponseDto.ConvertToResponse(owner);
            return new Response<OwnerResponseDto>
            {
                Data = response,
                Message = "Owner Bilgileri Gösteriliyor",
                StatusCode = System.Net.HttpStatusCode.Created
            };
        }


        catch (Exception ex)
        {

            return new Response<OwnerResponseDto>
            {
                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }
    }


    public Response<OwnerResponseDto> Update(OwnerUpdateRequest request)
    {
        try
        {
            //  _ruleManager.CompanyRules.CompanyIsPresent(companyUpdateRequest.Id);
            Owner owner= OwnerUpdateRequest.ConvertToEntity(request);

            _ownerRepository.Update(owner);

            //_ruleManager.CompanyRules.CompanyNameMustBeUnique(companyUpdateRequest.companyName);


            var response = OwnerResponseDto.ConvertToResponse(_ownerRepository.GetById(request.ownerId));
            return new Response<OwnerResponseDto>()
            {
                Data = response,
                Message = "Ürün başarıyla güncellendi.",
                StatusCode = System.Net.HttpStatusCode.OK

            };
        }
        catch (BusinessException ex)
        {
            return new Response<OwnerResponseDto>()
            {

                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest

            };
        }
    }
}