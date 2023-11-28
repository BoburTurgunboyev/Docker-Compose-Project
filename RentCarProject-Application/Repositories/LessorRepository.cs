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
    public class LessorRepository : ILessorRepository
    {
        private readonly RentCarDBContext _rentCarDB;

        public LessorRepository(RentCarDBContext rentCarDB)
        {
            _rentCarDB = rentCarDB;
        }
        public async ValueTask<bool> CreateAsync(Lessor entity)
        {
            await _rentCarDB.lessor.AddAsync(entity);
            var res = await _rentCarDB.SaveChangesAsync();
            return res > 0;
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            var res = await _rentCarDB.lessor.FirstOrDefaultAsync(x => x.Id == id); 
            if (res == null)
            {
                return false;
            }

            _rentCarDB.lessor.Update(res);
            var res1 = await _rentCarDB.SaveChangesAsync();
            return res1 > 0;
        }

        public async ValueTask<IList<Lessor>> GetAllAsync()
        {
            return await _rentCarDB.lessor.ToListAsync();
        }

        public async ValueTask<Lessor?> GetByIdAsync(int id)
        {
            var res = await _rentCarDB.lessor.FirstOrDefaultAsync(x => x.Id == id);
            return res;
        }

        public async ValueTask<bool> UpdateAsync(int id, Lessor entity)
        {
            _rentCarDB.lessor.Update(entity);
            var res = await _rentCarDB.SaveChangesAsync();
            return res > 0;
        }
    }
}
