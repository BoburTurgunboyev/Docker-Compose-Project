namespace RentCarProject.Services.Interfaces;

public interface IBaseService<Dto, Entity>
{
    public ValueTask<bool> CreateAsync(Dto entity);

    public ValueTask<bool> UpdateAsync(int id, Dto dto);

    public ValueTask<bool> DeleteAsync(int id);

    public ValueTask<IList<Entity>> GetAllAsync();

    public ValueTask<Entity> GetByIdAsync(int id);

}