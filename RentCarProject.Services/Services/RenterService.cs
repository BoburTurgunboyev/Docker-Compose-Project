using RentCarProject.Domain.Entities.Models;
using RentCarProject.Services.Dtos;
using RentCarProject.Services.Interfaces;

namespace RentCarProject.Services.Services
{
    public class RenterService : IRenterService
    {
        public ValueTask<bool> CreateAsync(RenterDto entity)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Renter>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> UpdateAsync(long id, RenterDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
