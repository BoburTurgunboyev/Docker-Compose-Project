using RentCarProject.Domain.Entities.Models;
using RentCarProject.Services.Dtos;
using RentCarProject.Services.Interfaces;
using RentCarProject_Application.Interfaces;
using RentCarProject_Application.Repositories;

namespace RentCarProject.Services.Services
{
    public class LessorService : ILessorService
    {
        private readonly ILessorRepository _lessorRepository;

        public LessorService(ILessorRepository lessorRepository)
        {
            _lessorRepository = lessorRepository;
        }
        public async ValueTask<bool> CreateAsync(LessorDto entity)
        {
            Lessor lessor = new Lessor()
            {
               
                Name = entity.Name

            };

            var res = await _lessorRepository.CreateAsync(lessor);
            return res;
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            var les = await _lessorRepository.DeleteAsync(id);
            return les;
        }

        public async ValueTask<IList<Lessor>> GetAllAsync()
        {
            return await _lessorRepository.GetAllAsync();
        }

        public async ValueTask<Lessor> GetByIdAsync(int id)
        {
            var res = await _lessorRepository.GetByIdAsync(id);
            return res;
        }

        public async ValueTask<bool> UpdateAsync(int id, LessorDto dto)
        {
            var res1 = await _lessorRepository.GetByIdAsync(id);

            res1.Name = dto.Name;

            var result = await _lessorRepository.UpdateAsync(id, res1);
            return result;
                

        }
    }
}
