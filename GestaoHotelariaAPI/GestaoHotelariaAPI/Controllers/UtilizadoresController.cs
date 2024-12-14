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

        // Injeção de dependência do contexto para acessar o banco de dados
        public UtilizadoresController(GestaoHotelariaContext context)
        {
            _context = context;
        }

        // GET: api/utilizadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Utilizador>>> GetUtilizadores()
        {
            // Retorna a lista de utilizadores
            return await _context.Utilizadores.ToListAsync();
        }

        // GET: api/utilizadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Utilizador>> GetUtilizador(int id)
        {
            // Busca um utilizador pelo ID
            var utilizador = await _context.Utilizadores.FindAsync(id);

            if (utilizador == null)
            {
                // Retorna 404 caso o utilizador não seja encontrado
                return NotFound();
            }

            return utilizador;
        }

        // POST: api/utilizadores
        [HttpPost]
        public async Task<ActionResult<Utilizador>> PostUtilizador(Utilizador utilizador)
        {
            // Adiciona o novo utilizador ao banco de dados
            _context.Utilizadores.Add(utilizador);
            await _context.SaveChangesAsync();

            // Retorna a URL do recurso criado
            return CreatedAtAction(nameof(GetUtilizador), new { id = utilizador.UtilizadorID }, utilizador);
        }

        // PUT: api/utilizadores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUtilizador(int id, Utilizador utilizador)
        {
            if (id != utilizador.UtilizadorID)
            {
                return BadRequest(); // Retorna 400 se o ID não coincidir
            }

            // Marca o utilizador como modificado
            _context.Entry(utilizador).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Retorna 204 (sem conteúdo)
        }

        // DELETE: api/utilizadores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUtilizador(int id)
        {
            var utilizador = await _context.Utilizadores.FindAsync(id);
            if (utilizador == null)
            {
                return NotFound(); // Retorna 404 se o utilizador não for encontrado
            }

            // Remove o utilizador do banco de dados
            _context.Utilizadores.Remove(utilizador);
            await _context.SaveChangesAsync();

            return NoContent(); // Retorna 204 (sem conteúdo)
        }
    }
}
