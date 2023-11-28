using RentCarProject.Domain.Entities.Models;
using RentCarProject.Services.Dtos;
using RentCarProject.Services.Interfaces;

namespace RentCarProject.Services.Services
{
    public class LessorService : ILessorService
    {
        public ValueTask<bool> CreateAsync(LessorDto entity)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Lessor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> UpdateAsync(long id, LessorDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
