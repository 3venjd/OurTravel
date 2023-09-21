﻿using OurTravel.Shared.Entities;

namespace OurTravel.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedDbAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country
                {
                    Name = "Colombia"
                });
                _context.Countries.Add(new Country
                {
                    Name = "Nicaragua"
                });
                _context.Countries.Add(new Country
                {
                    Name = "Honduras"
                });

                await _context.SaveChangesAsync();
            }
        }
    }
}
