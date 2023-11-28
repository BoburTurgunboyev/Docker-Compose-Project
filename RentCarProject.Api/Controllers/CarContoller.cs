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
    }
}
