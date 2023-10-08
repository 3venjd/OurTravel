using System.ComponentModel.DataAnnotations;

namespace OurTravel.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(100, ErrorMessage = "The field {0} can't be more than {1} characters")]
        public string? Name { get; set; }

        public string? Flag { get; set; }

        public string? Description { get; set; }

        public ICollection<State>? States { get; set; }

        public string? Capital { get; set; }

        public int QuantityStates => States == null ? 0 : States.Count;
    }
}
