namespace RentCarProject.Domain.Entities.Models
{
    public class Renter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Car Cars { get; set; }
    }
}
