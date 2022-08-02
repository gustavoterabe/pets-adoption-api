using Microsoft.EntityFrameworkCore;

namespace petAdoptionApi.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
    }
    
    
}
