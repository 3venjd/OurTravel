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
                    Flag = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Flag_of_Colombia.svg/2560px-Flag_of_Colombia.svg.png",
                    Capital = "Bogotá",
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
                    Name = "Nicaragua",
                    Flag = "data:image/png;base64,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",
                    Capital = "Managua"
                });
                _context.Countries.Add(new Country
                {
                    Name = "Honduras",
                    Flag = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAQQAAACCCAMAAACXSEZJAAAATlBMVEUAvOT///8AuOLM7PcAuuP0/P4AtuK65/XW8fnw+v37/v/f9PoAtOGT2/Cb3fHo+Pys4/NBxefF6/djzeuj4fN10+2B1e5RyumK2e8vwuYZ0uccAAAChUlEQVR4nO3aW2+jMBCGYWcw54RDCMny///o2sBdSaliz7pavY8qkauR+4HNGDAGAAAAAAAAAAAAAAAAAAAASEogJkNmLrgQwoUQVrohtG2kQmWkOsd0Q+huceq0S5w6b+iGMI5x6nRFH6fQMdUQepE4gx/lEaXOG1oh1HmeNw+RrnE/6s/r5L5QK3a8hNX5llYIlRFj7Ponpvq8Tj4Vdq9j1S4HtenQzGJ9W25lboIKDVsdI0usW80XimtCuW1Ogu9u/ehTsM8YYzqmuTC+/DX8Cq8ziA8hDy/0jmIItVgrVsJXs5cVN6uGCEN6QzEEdwKzyhTBg68L6fJXEeGSekcxhPGV+9X9rF/Kz1IarL+7dIXWDVIzhLrbjt3J4MuzU3zbVoNMb/+Qfhc5XVOP4BeEIKK7RfyBlCH0Vdu2bvmcencM6CqDpQwhn66F+O5a5BrSWgdLOx1Ku7fEiu3gDyReE/aW+J52FKkXxtmHIIkHkToEa+1i5b++Ek430ffCVM1UzMGFguiGcD87xdPk/73H2Xxo/kQa0DHdEOazU7zvG6qTG2Smu2rohmAilX8Wqm2EagiVSJzBG1GdD1ohZENZlrO1kzsM2ed1el/nIWa5u6PWJkMrhGa+ititJQ560jqsHxCsddSetOpNh7vZnjaHtoP1KFtrHemV3gHNZ4y+JbZL+AOh59paB8ypM5oL42J9Pxhe5+Zfv4jaWwfVEFqRZZEIg3dhTqI4GzRDuBVT49bH4MG3fkUcRPHtvGIIy9oODsGDf65tZ6v3Fk7zafM+6Cp0ZdzvLo1e05h6K/0rEMKFEFaE4PBZr8MH3iLyLz+oBwAAAAAAAAAAAAAAAAAAAL76C4VhQNvQaG2KAAAAAElFTkSuQmCC",
                    Capital = "Tegucigalpa"
                });

                await _context.SaveChangesAsync();
            }
        }
    }
}
