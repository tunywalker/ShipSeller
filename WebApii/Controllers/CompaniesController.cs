using DataAccess.Repositories.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos.RequestDto;
using Models.Dtos.RequestDto.CompanyRequests;
using Service.Abstract;
using WebAPI.Controllers;
public class CompaniesController : BaseController
{

    private readonly ICompanyService _companyService;

    public CompaniesController(ICompanyService companyService)
    {
        _companyService = companyService;
    }
    [HttpPost]
    public IActionResult Add([FromBody] CompanyAddRequest companyAddRequest)
    {
        var result = _companyService.Add(companyAddRequest);
        return ActionResultInstance(result);
    }


}

