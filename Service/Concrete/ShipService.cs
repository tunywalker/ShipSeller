
using Core.CrossCuttingConcerns.Exceptions;
using Core.Shared;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Concrete;
using Models.Dtos.RequestDto.OwnerRequests;
using Models.Dtos.RequestDto.ShipRequests;
using Models.Dtos.ResponseDto.EmployeeResponses;
using Models.Dtos.ResponseDto.OwnerResponses;
using Models.Dtos.ResponseDto.ShipResponses;
using Models.Entities;
using Service.Abstract;
using Service.BusinessRules.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete;

public class ShipService : IShipService
{
    private readonly IShipRepository _shipRepository;
    private readonly IBusinessRuleManager _ruleManager;

    public ShipService(IShipRepository shipRepository, IBusinessRuleManager ruleManager)
    {
        _shipRepository = shipRepository;
        _ruleManager = ruleManager;
    }

    public Response<ShipResponseDto> Add(ShipAddRequest request)
    {
        try
        {
            Ship ship = ShipAddRequest.ConvertToEntity(request);
            _shipRepository.Add(ship);
            ShipResponseDto response = ship;
            return new Response<ShipResponseDto>
            {
                Data = response,
                Message = "Gemi Başarıyla Eklendi.",
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
        catch (BusinessException ex)
        {

            return new Response<ShipResponseDto>
            {

                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }

    }

    public Response<ShipResponseDto> Delete(int id)
    {
        try
        {
            _ruleManager.ShipRules.ShipIsPresent(id);
            Ship ship = _shipRepository.GetById(id);

            ShipResponseDto response = ship;
            _shipRepository.Delete(ship);
            return new Response<ShipResponseDto>()
            {

                Data = response,
                StatusCode = System.Net.HttpStatusCode.OK,
                Message = "Ürün başarıyla silindi."
            };
        }
        catch (BusinessException ex)
        {

            return new Response<ShipResponseDto>
            {

                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
    }

    public Response<List<ShipResponseDto>> GetAll()
    {
        try
        {

            List<ShipResponseDto> response = _shipRepository.GetAll().Select(x => ShipResponseDto.ConvertToResponse(x)).ToList();

            return new Response<List<ShipResponseDto>>()
            {
                Data = response,
                Message = $"{response.Count} adet gemi bilgisi gösterililyor.",
                StatusCode = System.Net.HttpStatusCode.OK

            };
        }
        catch (BusinessException ex)
        {
            return new Response<List<ShipResponseDto>>()
            {
                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }

    }

    public Response<ShipResponseDto> GetById(int id)
    {
        try
        {
            _ruleManager.ShipRules.ShipIsPresent(id);
            Ship ship = _shipRepository.GetById(id);
            ShipResponseDto response = ship;
            return new Response<ShipResponseDto>()
            {
                Data = response,
                Message = "Gemi bilgileri gösteriliyor.",
                StatusCode = System.Net.HttpStatusCode.OK

            };
        }
        catch (BusinessException ex)
        {

            return new Response<ShipResponseDto>()
            {
                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }
        

    }

    public Response<ShipResponseDto> Update(ShipUpdateRequest request)
    {
        try
        {
            Ship ship = ShipUpdateRequest.ConvertToEntity(request);
            _ruleManager.ShipRules.ShipIsPresent(request.shipId);
            _ruleManager.CompanyRules.CompanyIsPresent(request.shipAuthorCompanyId);
            
            _shipRepository.Update(ship);



            var response = ShipResponseDto.ConvertToResponse(_shipRepository.GetById(request.shipId));
            
            return new Response<ShipResponseDto>()
            {
                Data = response,
                Message = "Gemi Bilgeileri Güncellendi",
                StatusCode = System.Net.HttpStatusCode.OK

            };
        }
        catch (BusinessException ex)
        {

            return new Response<ShipResponseDto>()
            {
                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }
    }
}
