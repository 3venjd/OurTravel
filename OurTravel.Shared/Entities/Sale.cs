using System.ComponentModel.DataAnnotations;

namespace OurTravel.Shared.Entities
{
    public class Sale
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(100, ErrorMessage = "The field {0} can't be more than {1} characters")]
        public int Quantity { get; set; }

        public float TotalSale { get; set; }
    }
}
