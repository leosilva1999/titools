using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiTiTools.Context;
using ApiTiTools.Models;

namespace ApiTiTools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CallersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Callers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Caller>>> GetCallers()
        {
          if (_context.Callers == null)
          {
              return NotFound();
          }
            return await _context.Callers.ToListAsync();
        }

        // GET: api/Callers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Caller>> GetCaller(int id)
        {
          if (_context.Callers == null)
          {
              return NotFound();
          }
            var caller = await _context.Callers.FindAsync(id);

            if (caller == null)
            {
                return NotFound();
            }

            return caller;
        }

        // PUT: api/Callers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCaller(int id, Caller caller)
        {
            if (id != caller.Id)
            {
                return BadRequest();
            }

            _context.Entry(caller).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CallerExists(id))
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

        // POST: api/Callers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Caller>> PostCaller(Caller caller)
        {
          if (_context.Callers == null)
          {
              return Problem("Entity set 'AppDbContext.Callers'  is null.");
          }
            _context.Callers.Add(caller);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCaller", new { id = caller.Id }, caller);
        }

        // DELETE: api/Callers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCaller(int id)
        {
            if (_context.Callers == null)
            {
                return NotFound();
            }
            var caller = await _context.Callers.FindAsync(id);
            if (caller == null)
            {
                return NotFound();
            }

            _context.Callers.Remove(caller);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CallerExists(int id)
        {
            return (_context.Callers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
