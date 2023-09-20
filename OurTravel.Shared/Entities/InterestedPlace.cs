using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurTravel.Shared.Entities
{
    public class InterestedPlace
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(100, ErrorMessage = "The field {0} can't be more than {1} characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(500, ErrorMessage = "The field {0} can't be more than {1} characters")]
        public string? Description { get; set; }

    }
}
