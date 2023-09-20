using System.ComponentModel.DataAnnotations;

namespace OurTravel.Shared.Entities
{
    public class Role
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="The field {0} is required")]
        [MaxLength(100, ErrorMessage ="The field {0} can't be more than {1} characters")]
        public string? Name { get; set; }
    }
}
