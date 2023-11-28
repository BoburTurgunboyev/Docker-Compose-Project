namespace RentCarProject.Domain.Entities.Models
{
    public class Lessor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
