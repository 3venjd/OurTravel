using System.ComponentModel.DataAnnotations;

namespace OurTravel.Shared.Entities
{
    //Shop/Agency
    public class Company
    {
        public int Id { get; set; }

        //NIT
        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(100, ErrorMessage = "The field {0} can't be more than {1} characters")]
        public string? LegalIdentifier { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(100, ErrorMessage = "The field {0} can't be more than {1} characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(100, ErrorMessage = "The field {0} can't be more than {1} characters")]
        public string? Address { get; set; }

        public string? Description { get; set; }

    }
}
