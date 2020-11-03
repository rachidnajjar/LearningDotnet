using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWebApi.Data;
using HelloWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HelloWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonnesController : ControllerBase
    {
        private readonly PersonneContext _context;

        public PersonnesController(PersonneContext context)
        {
            _context = context;
        }

        // GET: api/Personnes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personne>>> GetPersonnes()
        {
            return await _context.Personnes.ToListAsync();
        }

        // GET: api/Personnes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Personne>> GetPersonne(long id)
        {
            var personne = await _context.Personnes.FindAsync(id);

            if (personne == null)
            {
                return NotFound();
            }

            return personne;
        }

        // POST: api/Personnes
        [HttpPost]
        public async Task<ActionResult<Personne>> PostPersonne(Personne personne)
        {
            _context.Personnes.Add(personne);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetPersonne", new { id = personne.Id }, personne);
            return CreatedAtAction(nameof(GetPersonne), new { id = personne.Id }, personne);
        }


        // PUT: api/Personnes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonne(long id, Personne personne)
        {
            if (id != personne.Id)
            {
                return BadRequest();
            }

            _context.Entry(personne).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonneExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Personnes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonne(long id)
        {
            var personne = await _context.Personnes.FindAsync(id);
            if (personne == null)
            {
                return NotFound();
            }

            _context.Personnes.Remove(personne);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonneExists(long id)
        {
            return _context.Personnes.Any(e => e.Id == id);
        }
    }
}
