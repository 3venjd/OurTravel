﻿using System.ComponentModel.DataAnnotations;

namespace OurTravel.Shared.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(100, ErrorMessage = "The field {0} can't be more than {1} characters")]
        public string? Name { get; set;}

        public string? Description { get; set; }

        public int CountryId { get; set; }

        public Country? Country { get; set; }


        public ICollection<City>? Cities { get; set; }

        public string? Flag { get; set; }

        public int QuantityCities => Cities == null ? 0 : Cities.Count;
    }
}
