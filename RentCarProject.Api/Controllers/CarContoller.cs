using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCarProject.Services.Dtos;
using RentCarProject.Services.Interfaces;
using RentCarProject.Services.Services;

namespace RentCarProject.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarContoller : ControllerBase
    {
        private readonly ICarService _carService;

        public CarContoller(ICarService carService)
        {
            _carService = carService;
        }
        [HttpPost]
        public async ValueTask<ActionResult> CreateAsync( CarDto carDto)
            => Ok(await _carService.CreateAsync(carDto));

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            return Ok(await _carService.GetAllAsync());
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            return Ok(await _carService.DeleteAsync(id));
        }

        [HttpPut]

        public async ValueTask<IActionResult> UpdateAsync( int id,CarDto carDto) 
        {
            return Ok(await _carService.UpdateAsync(id,carDto));
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _carService.GetByIdAsync(id));
        }
    }
}
