using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos.RequestDto.CompanyRequests;
using Models.Dtos.RequestDto.OwnerRequests;
using Service.Abstract;
using Service.Concrete;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OwnerController : BaseController
{

    private readonly IOwnerService _ownerService;

    public OwnerController(IOwnerService ownerService)
    {
        _ownerService = ownerService;
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] OwnerAddRequest ownerAddRequest)
    {
        var result = _ownerService.Add(ownerAddRequest);
        return ActionResultInstance(result);
    }

    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] int id)
    {
        var result = _ownerService.Delete(id);
        return ActionResultInstance(result);
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _ownerService.GetAll();
        return ActionResultInstance(result);
    }


    [HttpGet("getbyid")]
    public IActionResult GetById([FromQuery] int id)
    {
        var result = _ownerService.GetById(id);
        return ActionResultInstance(result);
    }
   
    [HttpPut("update")]
    public IActionResult Update([FromBody] OwnerUpdateRequest ownerUpdateRequest)
    {
        var result = _ownerService.Update(ownerUpdateRequest);
        return ActionResultInstance(result);
    }
}
