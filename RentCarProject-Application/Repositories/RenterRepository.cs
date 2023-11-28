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
    public class RenterRepository : IRenterRepository
    {
        private readonly RentCarDBContext _rentCarDB;

        public RenterRepository(RentCarDBContext rentCarDB) 
        {
            _rentCarDB = rentCarDB;
        }

        public async ValueTask<bool> CreateAsync(Renter entity)
        {
            await _rentCarDB.renter.AddAsync(entity);
            var res = await _rentCarDB.SaveChangesAsync();
            return res > 0;
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            var res = await _rentCarDB.renter.FirstOrDefaultAsync(x => x.Id == id);  
            if (res == null)
            {
                return false;
            }

            _rentCarDB.renter.Remove(res);
            var res1 = await _rentCarDB.SaveChangesAsync();
            return res1 > 0;
        }

        public async ValueTask<IList<Renter>> GetAllAsync()
        {
            return await _rentCarDB.renter.ToListAsync();
        }

        public async ValueTask<bool> UpdateAsync(long id, Renter entity)
        {
            _rentCarDB.renter.Update(entity);
            var res = await _rentCarDB.SaveChangesAsync();
            return res > 0;
        }
    }
}
