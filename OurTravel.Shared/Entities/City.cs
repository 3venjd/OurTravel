﻿using System.ComponentModel.DataAnnotations;

namespace OurTravel.Shared.Entities
{
    public class City
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(100, ErrorMessage = "The field {0} can't be more than {1} characters")]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public int StateId { get; set; }

        public string? Flag { get; set; }

        public State? State { get; set; }

        public ICollection<InterestedPlace>? Places { get; set;}

        public int QuantityPlaces => Places == null ? 0 : Places.Count;

    }
}
