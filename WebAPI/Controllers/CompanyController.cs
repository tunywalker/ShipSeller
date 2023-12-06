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

    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] int id)
    {
        var result = _companyService.Delete(id);
        return ActionResultInstance(result);
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _companyService.GetAllCompanyDetails();
        return ActionResultInstance(result);
    }
   

    [HttpGet("getbyid")]
    public IActionResult GetById([FromQuery] int id)
    {
        var result= _companyService.GetById(id);
        return ActionResultInstance(result);
    }
    [HttpGet("getbyname")]
    public IActionResult GetByName([FromQuery]  string categoryName)
    {
        var result = _companyService.GetDetailsByCompanyName(categoryName);
        return ActionResultInstance(result);
    }
    [HttpPut("update")]
    public IActionResult Update([FromBody] CompanyUpdateRequest companyUpdateRequest)
    {
        var result = _companyService.Update(companyUpdateRequest);
        return ActionResultInstance(result);
    }


}

