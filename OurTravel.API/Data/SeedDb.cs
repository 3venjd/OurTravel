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
                    Description = "Colombia is a country located in the northwestern part of South America, bordered by the Caribbean Sea to the north, Venezuela and Brazil to the east, Peru and Ecuador to the south, and Panama to the northwest. It also shares maritime borders with Costa Rica, Nicaragua, Honduras, Jamaica, the Dominican Republic, and Haiti. The country's diverse geography ranges from tropical rainforests in the Amazon to the highlands of the Andes mountains.",
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
                            },
                            Flag = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/33/Flag_of_Antioquia_Department.svg/1200px-Flag_of_Antioquia_Department.svg.png"
                        },
                        new State
                        {
                            Name = "Bogotá DC",
                            Cities = new List<City>
                            {
                                new City
                                {
                                    Name = "Bogotá"
                                }
                            },
                            Flag = "data:image/png;base64,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"
                        },
                    }

                });
                _context.Countries.Add(new Country
                {
                    Name = "Nicaragua",
                    Flag = "data:image/png;base64,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",
                    Capital = "Managua",
                    Description = "Nicaragua is the largest country in Central America, bordered by Honduras to the north and Costa Rica to the south. It boasts both Pacific and Caribbean coastlines. The country is known for its dramatic landscapes, which include lakes, volcanoes, and rainforests. Managua is its capital and largest city. Nicaragua has a rich cultural history influenced by indigenous and Spanish heritages. It's renowned for its traditional music, dance, and festivals. The nation has faced political challenges but remains a captivating destination for travelers."
                });
                _context.Countries.Add(new Country
                {
                    Name = "Honduras",
                    Flag = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAQQAAACCCAMAAACXSEZJAAAATlBMVEUAvOT///8AuOLM7PcAuuP0/P4AtuK65/XW8fnw+v37/v/f9PoAtOGT2/Cb3fHo+Pys4/NBxefF6/djzeuj4fN10+2B1e5RyumK2e8vwuYZ0uccAAAChUlEQVR4nO3aW2+jMBCGYWcw54RDCMny///o2sBdSaliz7pavY8qkauR+4HNGDAGAAAAAAAAAAAAAAAAAAAASEogJkNmLrgQwoUQVrohtG2kQmWkOsd0Q+huceq0S5w6b+iGMI5x6nRFH6fQMdUQepE4gx/lEaXOG1oh1HmeNw+RrnE/6s/r5L5QK3a8hNX5llYIlRFj7Ponpvq8Tj4Vdq9j1S4HtenQzGJ9W25lboIKDVsdI0usW80XimtCuW1Ogu9u/ehTsM8YYzqmuTC+/DX8Cq8ziA8hDy/0jmIItVgrVsJXs5cVN6uGCEN6QzEEdwKzyhTBg68L6fJXEeGSekcxhPGV+9X9rF/Kz1IarL+7dIXWDVIzhLrbjt3J4MuzU3zbVoNMb/+Qfhc5XVOP4BeEIKK7RfyBlCH0Vdu2bvmcencM6CqDpQwhn66F+O5a5BrSWgdLOx1Ku7fEiu3gDyReE/aW+J52FKkXxtmHIIkHkToEa+1i5b++Ek430ffCVM1UzMGFguiGcD87xdPk/73H2Xxo/kQa0DHdEOazU7zvG6qTG2Smu2rohmAilX8Wqm2EagiVSJzBG1GdD1ohZENZlrO1kzsM2ed1el/nIWa5u6PWJkMrhGa+ititJQ560jqsHxCsddSetOpNh7vZnjaHtoP1KFtrHemV3gHNZ4y+JbZL+AOh59paB8ypM5oL42J9Pxhe5+Zfv4jaWwfVEFqRZZEIg3dhTqI4GzRDuBVT49bH4MG3fkUcRPHtvGIIy9oODsGDf65tZ6v3Fk7zafM+6Cp0ZdzvLo1e05h6K/0rEMKFEFaE4PBZr8MH3iLyLz+oBwAAAAAAAAAAAAAAAAAAAL76C4VhQNvQaG2KAAAAAElFTkSuQmCC",
                    Capital = "Tegucigalpa",
                    Description = "Honduras is a Central American country bordered by Guatemala to the west, El Salvador to the southwest, Nicaragua to the southeast, and the Caribbean Sea to the north. Its landscape is characterized by mountains, rainforests, and coastal plains. Tegucigalpa is the capital and largest city. Honduras is known for its rich Mayan heritage, especially the ancient ruins of Copán. The country has a diverse culture influenced by indigenous, Spanish, and African heritages. It's also renowned for its natural beauty, including the Bay Islands, a popular diving destination."
                });

                await _context.SaveChangesAsync();
            }
        }
    }
}
