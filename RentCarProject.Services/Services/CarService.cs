using RentCarProject.Domain.Entities.Models;
using RentCarProject.Services.Dtos;
using RentCarProject.Services.Interfaces;
using RentCarProject_Application.Interfaces;

namespace RentCarProject.Services.Services;

public class CarService : ICarService
{
    private readonly ICarRepository _carRepository;

    public CarService(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }
    public async ValueTask<bool> CreateAsync(CarDto entity)
    {
        Car car = new Car()
        {
            
            Name = entity.Name,
            Marka = entity.Marka,
            LessorId = entity.LessorId,
            RenterId = entity.RenterId,


        };
        var res = await _carRepository.CreateAsync(car);
        return res;
    }

    public async ValueTask<bool> DeleteAsync(int id)
    {
        var caar = await _carRepository.DeleteAsync(id);
        return caar;
    }

    public async ValueTask<IList<Car>> GetAllAsync()
    {
        return await _carRepository.GetAllAsync();
    }

    public async ValueTask<Car> GetByIdAsync(int id)
    {
        var result = await _carRepository.GetByIdAsync(id);
        return result;
    }

    public async ValueTask<bool> UpdateAsync(int id, CarDto dto)
    {
        var res = await _carRepository.GetByIdAsync(id); 
        res.Name = dto.Name;
        res.Marka = dto.Marka;

        var res1 = await _carRepository.UpdateAsync(id, res);

        return res1;

    }


}
