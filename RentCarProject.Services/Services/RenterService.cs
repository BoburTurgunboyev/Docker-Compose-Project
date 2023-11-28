using RentCarProject.Domain.Entities.Models;
using RentCarProject.Services.Dtos;
using RentCarProject.Services.Interfaces;
using RentCarProject_Application.Interfaces;
using RentCarProject_Application.Repositories;

namespace RentCarProject.Services.Services
{
    public class RenterService : IRenterService
    {
        private readonly IRenterRepository _renterRepository;

        public RenterService(IRenterRepository renterRepository)
        {
            _renterRepository = renterRepository;
        }
        public async ValueTask<bool> CreateAsync(RenterDto entity)
        {
            Renter renter = new Renter() 
            {
                Name = entity.Name,
                Address = entity.Address,
                Phone = entity.Phone,
            };

            var res = await _renterRepository.CreateAsync(renter);
            return res;
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            var res = await _renterRepository.DeleteAsync(id);
            return res;
        }

        public async ValueTask<IList<Renter>> GetAllAsync()
        {
            var result = await _renterRepository.GetAllAsync();
            return result;
        }

        public async ValueTask<Renter> GetByIdAsync(int id)
        {
            var res = await _renterRepository.GetByIdAsync(id);
            return res;
        }


        public async ValueTask<bool> UpdateAsync(int id, RenterDto dto)
        {
            var res = await _renterRepository.GetByIdAsync(id);
            res.Name = dto.Name;
            res.Address = dto.Address;
            res.Phone = dto.Phone;

            var result = await _renterRepository.UpdateAsync(id, res);
            return result;
        }
    }
}
