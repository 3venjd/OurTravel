using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OurTravel.API.Data;
using OurTravel.Shared.Entities;

namespace OurTravel.API.Controllers
{
    [ApiController]
    [Route("/api/places")]
    public class InterestedPlaceController : ControllerBase
    {
        private readonly DataContext _context;

        public InterestedPlaceController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(
                    await _context.interestedPlaces
                    .Include(p => p.GalleryInterestedPlaces)
                    .ToListAsync()
                );
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var places = await _context.interestedPlaces
                                    .Include(x => x.GalleryInterestedPlaces!)
                                    .FirstOrDefaultAsync(x => x.Id == id);
            if (places == null)
            {
                return NotFound();
            }
            return Ok(places);
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(InterestedPlace place)
        {
            try
            {
                _context.Add(place);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("A place with the same name already exist");
                }

                return BadRequest(dbUpdateException.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(InterestedPlace place)
        {
            try
            {
                _context.Update(place);
                await _context.SaveChangesAsync();
                return Ok(place);
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("A country with the same name already exist");
                }

                return BadRequest(dbUpdateException.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var country = await _context
                                .interestedPlaces
                                .FirstOrDefaultAsync(x => x.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            _context.Remove(country);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
