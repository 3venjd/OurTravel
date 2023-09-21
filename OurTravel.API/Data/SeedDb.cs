using OurTravel.Shared.Entities;

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
                    Name = "Colombia",
                    States = new List<State> {
                        new State
                        {
                            Name = "Antioquia",
                            Cities = new List<City>
                            {
                                new City
                                {
                                    Name = "Medellín"
                                },
                                new City
                                {
                                    Name = "Río Negro"
                                },
                                new City
                                {
                                    Name = "Envigado"
                                },
                                new City
                                {
                                    Name = "Itagüi"
                                },
                                new City
                                {
                                    Name = "Bello"
                                },
                                new City
                                {
                                    Name = "Copacabana"
                                },
                            }
                        },
                    }

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
