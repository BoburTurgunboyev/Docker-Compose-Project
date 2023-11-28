using Microsoft.EntityFrameworkCore;
using RentCarProject.Domain.Entities.Models;
using RentCarProject_Application.Data;
using RentCarProject_Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarProject_Application.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly RentCarDBContext _rentCarDB;

        public CarRepository(RentCarDBContext rentCarDB)
        {
            _rentCarDB = rentCarDB;
        }
        public async ValueTask<bool> CreateAsync(Car entity)
        {
            await _rentCarDB.cars.AddAsync(entity);
            var res = await _rentCarDB.SaveChangesAsync();
            return res > 0;
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            var res =await _rentCarDB.cars.FirstOrDefaultAsync(x => x.Id == id); 
            if (res == null)
            {
                return false;
            }
            _rentCarDB.cars.Update(res);
            var result=await _rentCarDB.SaveChangesAsync();
            return result > 0;  
        }

        public async ValueTask<IList<Car>> GetAllAsync()
        {
            return await _rentCarDB.cars.ToListAsync();
        }

        public async ValueTask<Car?> GetByIdAsync(int id)
        {
            var res = await _rentCarDB.cars.FirstOrDefaultAsync(x => x.Id == id);

            return res;
        }

        public async ValueTask<bool> UpdateAsync(int id, Car entity)
        {
            _rentCarDB.cars.Update(entity);
            var res = await _rentCarDB.SaveChangesAsync();   
            return res > 0;

        }
    }
}
