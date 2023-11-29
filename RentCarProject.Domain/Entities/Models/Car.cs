using System.Diagnostics.Metrics;

namespace RentCarProject.Domain.Entities.Models; 


public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Marka { get; set; }
    public int LessorId { get; set; }
    public Lessor Lessor { get; set; }
    public int RenterId { get; set; }
    public Renter Renter { get; set; }
}
