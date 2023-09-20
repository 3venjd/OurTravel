using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OurTravel.API.Data;
using OurTravel.Shared.Entities;

namespace OurTravel.API.Controllers
{
    [ApiController]
    [Route("/api/countries")]
    public class CountriesController : ControllerBase
    {
        private readonly DataContext _context;

        public CountriesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Countries.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> PostAsycn(Country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
