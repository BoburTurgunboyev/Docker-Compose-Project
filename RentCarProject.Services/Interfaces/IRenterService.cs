using RentCarProject.Domain.Entities.Models;
using RentCarProject.Services.Dtos;

namespace RentCarProject.Services.Interfaces
{

    public interface IRenterService : IBaseService<RenterDto, Renter>
    {
    }
}
