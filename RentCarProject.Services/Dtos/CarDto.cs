using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarProject.Services.Dtos
{
    public class CarDto
    {
        public string Name { get; set; }
        public string Marka { get; set; }
        public int LessorId { get; set; }
        public int RenterId { get; set; }

    }
        
}
