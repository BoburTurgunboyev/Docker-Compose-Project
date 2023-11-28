using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarProject_Application.Interfaces
{
    public interface IBaseRepository<Entity> where Entity : class
    {
        public ValueTask<bool> CreateAsync(Entity entity);

        public ValueTask<bool> UpdateAsync(long id, Entity entity);

        public ValueTask<bool> DeleteAsync(int id);

        public ValueTask<IList<Entity>> GetAllAsync();

       
    }
}
