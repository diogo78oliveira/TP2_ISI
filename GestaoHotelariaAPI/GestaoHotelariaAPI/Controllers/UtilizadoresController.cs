using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestaoHotelariaAPI.Models;

namespace GestaoHotelariaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilizadoresController : ControllerBase
    {
        private readonly GestaoHotelariaContext _context;

        
        public UtilizadoresController(GestaoHotelariaContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Utilizador>>> GetUtilizadores()
        {
            
            return await _context.Utilizadores.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Utilizador>> GetUtilizador(int id)
        {
            
            var utilizador = await _context.Utilizadores.FindAsync(id);

            if (utilizador == null)
            {
                
                return NotFound();
            }

            return utilizador;
        }


        [HttpPost]
        public async Task<ActionResult<Utilizador>> PostUtilizador(Utilizador utilizador)
        {
            
            _context.Utilizadores.Add(utilizador);
            await _context.SaveChangesAsync();

           
            return CreatedAtAction(nameof(GetUtilizador), new { id = utilizador.UtilizadorID }, utilizador);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUtilizador(int id, Utilizador utilizador)
        {
            if (id != utilizador.UtilizadorID)
            {
                return BadRequest(); 
            }

           
            _context.Entry(utilizador).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); 
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUtilizador(int id)
        {
            var utilizador = await _context.Utilizadores.FindAsync(id);
            if (utilizador == null)
            {
                return NotFound(); 
            }

            
            _context.Utilizadores.Remove(utilizador);
            await _context.SaveChangesAsync();

            return NoContent(); 
        }
    }
}
