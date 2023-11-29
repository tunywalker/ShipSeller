using DataAccess.Repositories.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos.RequestDto;
using Models.Dtos.RequestDto.CompanyRequests;
using Service.Abstract;
using WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CompanyController : BaseController
{

    private readonly ICompanyService _companyService;

    public CompanyController(ICompanyService companyService)
    {
        _companyService = companyService;
    }
    [HttpPost("add")]
    public IActionResult Add([FromBody] CompanyAddRequest companyAddRequest)
    {
        var result = _companyService.Add(companyAddRequest);
        return ActionResultInstance(result);
    }

    [HttpDelete]
    public IActionResult Delete([FromQuery] int id)
    {
        var result = _companyService.Delete(id);
        return ActionResultInstance(result);
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _companyService.GetAll();
        return ActionResultInstance(result);
    }

}

