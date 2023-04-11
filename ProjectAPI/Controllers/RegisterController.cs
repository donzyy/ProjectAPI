using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.DatabaseContext;
using ProjectAPI.Model;

namespace ProjectAPI.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly Database _context;

        public RegisterController(Database context)
        {
            _context = context;
        }

        // GET: api/Register
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Register>>> GetRegistration()
        {
            return await _context.Registration.ToListAsync();
        }

        // GET: api/Register/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Register>> GetRegister(Guid id)
        {
            var register = await _context.Registration.FindAsync(id);

            if (register == null)
            {
                return NotFound();
            }

            return register;
        }

          //Micheals Edit to create a new get method
        [HttpGet]
        public async Task<ActionResult<Register>> GetLogin(string email, string password)
        {
            var response = await _context.Registration.Where(e => e.Email == email && e.Password == password).FirstOrDefaultAsync();

            if (response == null)
            {
                return NotFound();
            }

            return response;
        }
        //Micheals Edit to create a newa GetLogin method

        // PUT: api/Register/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegister(Guid id, Register register)
        {
            if (id != register.Id)
            {
                return BadRequest();
            }

            _context.Entry(register).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegisterExists(id))
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

        // POST: api/Register
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Register>> PostRegister(Register register)
        {
            _context.Registration.Add(register);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRegister", new { id = register.Id }, register);
        }

        // DELETE: api/Register/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegister(Guid id)
        {
            var register = await _context.Registration.FindAsync(id);
            if (register == null)
            {
                return NotFound();
            }

            _context.Registration.Remove(register);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RegisterExists(Guid id)
        {
            return _context.Registration.Any(e => e.Id == id);
        }
    }
}
