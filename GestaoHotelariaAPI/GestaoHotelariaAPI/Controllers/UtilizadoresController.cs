using GestaoHotelariaAPI.Models;
using GestaoHotelariaAPI.Service.UtilizadorService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoHotelariaAPI.Controllers
{
    /// <summary>
    /// Controlador para gerir os utilizadores do sistema.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "gestor")]

    public class UtilizadoresController : ControllerBase
    {
        private readonly IUtilizador _utilizadorService;

        /// <summary>
        /// Inicializa o controlador de utilizadores.
        /// </summary>
        /// <param name="utilizadorService">Serviço de utilizadores para execução das operações.</param>
        public UtilizadoresController(IUtilizador utilizadorService)
        {
            _utilizadorService = utilizadorService;
        }

        /// <summary>
        /// Obtém a lista de todos os utilizadores.
        /// </summary>
        /// <returns>Lista de utilizadores.</returns>
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Utilizador>>>> GetUtilizadores()
        {
            var response = await _utilizadorService.GetUtilizadores();
            if (!response.Sucesso)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        /// <summary>
        /// Obtém os dados de um utilizador específico pelo ID.
        /// </summary>
        /// <param name="id">ID do utilizador.</param>
        /// <remarks> Como usar: Inserir o ID do utilizador a ser procurado </remarks>
        /// <returns>Dados do utilizador solicitado.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Utilizador>>> GetUtilizadorById(int id)
        {
            var response = await _utilizadorService.GetUtilizadorById(id);
            if (!response.Sucesso)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        /// <summary>
        /// Cria um novo utilizador.
        /// </summary>
        /// <param name="newUtilizador">Dados do novo utilizador.</param>
        /// <remarks>
        /// Exemplo de uso em JSON:
        /// {
        ///   "utilizadorID": 0,
        ///   "nome": "Dinis Sousa",
        ///   "email": "dinis@email.com",
        ///   "perfil": "cliente",
        ///   "password": "dinissousa999"
        /// }
        /// </remarks>
        /// <returns>Resultado da criação do utilizador.</returns>
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Utilizador>>>> CreateUtilizador(Utilizador newUtilizador)
        {
            var response = await _utilizadorService.CreateUtilizador(newUtilizador);
            if (!response.Sucesso)
            {
                return BadRequest(response);
            }
            return CreatedAtAction(nameof(GetUtilizadorById), new { id = newUtilizador.UtilizadorID }, response);
        }

        /// <summary>
        /// Atualiza os dados de um utilizador existente.
        /// </summary>
        /// <remarks>
        /// Exemplo de uso em JSON:
        /// {
        ///   "utilizadorID": 3021(id do utilizador a ser alterado),
        ///   "nome": "Dinis Sousa Edit",
        ///   "email": "dinisEdit@email.com",
        ///   "perfil": "cliente",
        ///   "password": "dinissousa999Edit"
        /// }
        /// </remarks>
        /// <param name="editUtilizador">Dados do utilizador a ser atualizado.</param>
        /// <returns>Resultado da atualização do utilizador.</returns>
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<Utilizador>>>> UpdateUtilizador(Utilizador editUtilizador)
        {
            var response = await _utilizadorService.UpdateUtilizador(editUtilizador);
            if (!response.Sucesso)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        /// <summary>
        /// Elimina um utilizador pelo ID.
        /// </summary>
        /// <param name="id">ID do utilizador a eliminar.</param>
        /// <remarks> Como usar: Inserir o ID do utilizador a ser removido </remarks>
        /// <returns>Resultado da eliminação do utilizador.</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Utilizador>>>> DeleteUtilizador(int id)
        {
            var response = await _utilizadorService.DeleteUtilizador(id);
            if (!response.Sucesso)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
