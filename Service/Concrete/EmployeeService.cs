using Azure.Core;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Shared;
using DataAccess.Repositories.Abstracts;
using Models.Dtos.RequestDto.EmployeeRequests;
using Models.Dtos.ResponseDto.EmployeeResponses;
using Models.Entities;
using Service.Abstract;
using Service.BusinessRules.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IBusinessRuleManager _ruleManager;

    public EmployeeService(IEmployeeRepository employeeRepository, IBusinessRuleManager ruleManager)
    {
        _employeeRepository = employeeRepository;
        _ruleManager = ruleManager;
    }

    public Response<EmployeeResponseDto> Add(EmployeeAddRequest request)
    {
        try
        {
            Employee employee = EmployeeAddRequest.ConvertToEntity(request);
            _ruleManager.EmployeeRules.EmployeeSalaryMoreThanZero(request.employeeSalary);
            _ruleManager.EmployeeRules.CheckEmployeeName(request.employeeName);
            _ruleManager.CompanyRules.CompanyIsPresent(request.CompanyId);
            _employeeRepository.Add(employee);
            EmployeeResponseDto response = employee;

            return new Response<EmployeeResponseDto>
            {
                Data = response,
                Message = "Çalışan başarıyla eklendi",
                StatusCode = System.Net.HttpStatusCode.Created

            };
        }
        catch (BusinessException ex)
        {

            return new Response<EmployeeResponseDto>
            {
                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }
    }

    public Response<EmployeeResponseDto> Delete(Guid id)
    {
        try
        {
            _ruleManager.EmployeeRules.EmployeeIsPresent(id);
            Employee employee = _employeeRepository.GetById(id);
            _employeeRepository.Delete(employee);
            return new Response<EmployeeResponseDto>
            {
                Data = employee,
                Message = "Çalışan başarıyla silindi.",
                StatusCode = System.Net.HttpStatusCode.OK


            };

        }
        catch (BusinessException ex)
        {
            return new Response<EmployeeResponseDto>
            {

                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest


            };

        }

    }

    public Response<List<EmployeeResponseDto>> GetAll()
    {
        try
        {
            var employees = _employeeRepository.GetAll()
     .Select(employee => EmployeeResponseDto.convertToResponse(employee))
     .ToList();
            return new Response<List<EmployeeResponseDto>>
            {
                Data = employees,
                Message = $"{employees.Count} çalışan bilgisi gösteriliyor.",
                StatusCode = System.Net.HttpStatusCode.OK

            };
        }
        catch (BusinessException ex)
        {

            return new Response<List<EmployeeResponseDto>>
            {

                Message = $"{ex.Message}",
                StatusCode = System.Net.HttpStatusCode.BadRequest

            };
        }

    }

    public Response<EmployeeResponseDto> GetById(Guid id)
    {
        try
        {
            _ruleManager.EmployeeRules.EmployeeIsPresent(id);
            var employee = _employeeRepository.GetById(id);
            var response = EmployeeResponseDto.convertToResponse(employee);

            return new Response<EmployeeResponseDto>
            {
                Data = response,
                Message = "Çalışan bilgileri gösteriliyor.",
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
        catch (BusinessException ex)
        {
            return new Response<EmployeeResponseDto>
            {

                Message = $"{ex.Message}",
                StatusCode = System.Net.HttpStatusCode.BadRequest

            };
        }



    }

    public Response<EmployeeResponseDto> Update(EmployeeUpdateRequest request)
    {
        try
        {
            Employee employee = EmployeeUpdateRequest.ConvertToEntity(request);
            _employeeRepository.Update(employee);

            return new Response<EmployeeResponseDto>
            {
                Data = employee,
                Message = "Başarıyla güncellendi.",
                StatusCode = System.Net.HttpStatusCode.OK

            };

        }
        catch (BusinessException ex)
        {

            return new Response<EmployeeResponseDto>
            {
                Message = ex.Message,
                StatusCode= System.Net.HttpStatusCode.BadRequest

            };
        }
     
      
    }
}
