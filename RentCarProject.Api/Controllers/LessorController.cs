using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCarProject.Services.Dtos;
using RentCarProject.Services.Interfaces;
using RentCarProject.Services.Services;
using RentCarProject_Application.Interfaces;
using RentCarProject_Application.Repositories;

namespace RentCarProject.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LessorController : ControllerBase
    {
        private readonly ILessorService _lessorService;

        public LessorController(ILessorService lessorService)
        {
            _lessorService = lessorService;
        }

        [HttpPost]
        public async ValueTask<ActionResult> CreateAsync(LessorDto lessorDto)
           => Ok(await _lessorService.CreateAsync(lessorDto));

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            return Ok(await _lessorService.GetAllAsync());
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            return Ok(await _lessorService.DeleteAsync(id));
        }

        [HttpPut]

        public async ValueTask<IActionResult> UpdateAsync(int id, LessorDto lessorDto)
        {
            return Ok(await _lessorService.UpdateAsync(id, lessorDto));
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _lessorService.GetByIdAsync(id));
        }
    }
}
