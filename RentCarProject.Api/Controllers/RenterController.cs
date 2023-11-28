using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCarProject.Services.Dtos;
using RentCarProject.Services.Interfaces;
using RentCarProject.Services.Services;

namespace RentCarProject.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RenterController : ControllerBase
    {
        private readonly IRenterService _renterService;

        public RenterController(IRenterService renterService)
        {
            _renterService = renterService;
        }


        [HttpPost]
        public async ValueTask<ActionResult> CreateAsync(RenterDto renterDto)
           => Ok(await _renterService.CreateAsync(renterDto));

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            return Ok(await _renterService.GetAllAsync());
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            return Ok(await _renterService.DeleteAsync(id));
        }

        [HttpPut]

        public async ValueTask<IActionResult> UpdateAsync(int id, RenterDto renterDto)
        {
            return Ok(await _renterService.UpdateAsync(id,renterDto));
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _renterService.GetByIdAsync(id));
        }


    }


}
