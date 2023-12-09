using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos.RequestDto.EmployeeRequests;
using Models.Dtos.ResponseDto.EmployeeResponses;
using Service.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpPost("add")]
        public IActionResult Add(EmployeeAddRequest addRequest)
        {
            return ActionResultInstance<EmployeeResponseDto>(_employeeService.Add(addRequest));
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return ActionResultInstance<List<EmployeeResponseDto>>(_employeeService.GetAll());
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(Guid id)
        {
            return ActionResultInstance<EmployeeResponseDto>(_employeeService.GetById(id));
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Guid id)
        {
            return ActionResultInstance<EmployeeResponseDto>(_employeeService.Delete(id));
        }
        [HttpPut("update")]
        public IActionResult Update(EmployeeUpdateRequest updateRequest)
        {
            return ActionResultInstance<EmployeeResponseDto>(_employeeService.Update(updateRequest));
        }
    }
}
