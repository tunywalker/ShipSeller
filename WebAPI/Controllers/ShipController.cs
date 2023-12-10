using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos.RequestDto.ShipRequests;
using Models.Dtos.ResponseDto.ShipResponses;
using Service.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipController : BaseController
    {
        private readonly IShipService _shipService;

        public ShipController(IShipService shipService)
        {
            _shipService = shipService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            return ActionResultInstance<List<ShipResponseDto>>(_shipService.GetAll());
        }
        [HttpGet("getbyid")]
        public IActionResult GetById([FromQuery] int id)
        {
            return ActionResultInstance<ShipResponseDto>(_shipService.GetById(id));

        }
        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] int id)
        {
            return ActionResultInstance<ShipResponseDto>(_shipService.Delete(id));

        }
        [HttpPut("update")]
        public IActionResult Update([FromBody] ShipUpdateRequest request)
        {
            return ActionResultInstance<ShipResponseDto>(_shipService.Update(request));

        }

    }
}
