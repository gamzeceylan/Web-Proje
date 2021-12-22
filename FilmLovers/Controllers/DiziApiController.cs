using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FilmLovers.Data;
using FilmLovers.Models;

namespace FilmLovers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiziApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DiziApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/DiziApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dizi>>> GetDizi()
        {
            return await _context.Dizi.ToListAsync();
        }

        // GET: api/DiziApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dizi>> GetDizi(int id)
        {
            var dizi = await _context.Dizi.FindAsync(id);

            if (dizi == null)
            {
                return NotFound();
            }

            return dizi;
        }

        // PUT: api/DiziApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDizi(int id, Dizi dizi)
        {
            if (id != dizi.Id)
            {
                return BadRequest();
            }

            _context.Entry(dizi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiziExists(id))
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

        // POST: api/DiziApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dizi>> PostDizi(Dizi dizi)
        {
            _context.Dizi.Add(dizi);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDizi", new { id = dizi.Id }, dizi);
        }

        // DELETE: api/DiziApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDizi(int id)
        {
            var dizi = await _context.Dizi.FindAsync(id);
            if (dizi == null)
            {
                return NotFound();
            }

            _context.Dizi.Remove(dizi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DiziExists(int id)
        {
            return _context.Dizi.Any(e => e.Id == id);
        }
    }
}
