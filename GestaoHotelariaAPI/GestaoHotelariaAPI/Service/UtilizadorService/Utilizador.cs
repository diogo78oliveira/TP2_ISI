using GestaoHotelariaAPI.Service.UtilizadorService;
using GestaoHotelariaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ISI_WebAPI.Service.UtilizadorService
{
    public class UtilizadorService : IUtilizador
    {
        private readonly GestaoHotelariaContext _context;

        public UtilizadorService(GestaoHotelariaContext context)
        {
            _context = context;
        }

        // Obter todos os utilizadores
        public async Task<ServiceResponse<List<Utilizador>>> GetUtilizadores()
        {
            ServiceResponse<List<Utilizador>> serviceResponse = new ServiceResponse<List<Utilizador>>();
            try
            {
                serviceResponse.Dados = await _context.Utilizadores.ToListAsync();
                if (serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Mensagem = "Nenhum utilizador encontrado.";
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

        // Obter um utilizador por ID
        public async Task<ServiceResponse<Utilizador>> GetUtilizadorById(int id)
        {
            ServiceResponse<Utilizador> serviceResponse = new ServiceResponse<Utilizador>();
            try
            {
                var utilizador = await _context.Utilizadores.FirstOrDefaultAsync(x => x.UtilizadorID == id);
                if (utilizador == null)
                {
                    serviceResponse.Mensagem = "Utilizador não encontrado.";
                    serviceResponse.Sucesso = false;
                }
                else
                {
                    serviceResponse.Dados = utilizador;
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

        // Criar um novo utilizador
        public async Task<ServiceResponse<List<Utilizador>>> CreateUtilizador(Utilizador newUtilizador)
        {
            ServiceResponse<List<Utilizador>> serviceResponse = new ServiceResponse<List<Utilizador>>();
            try
            {
                if (newUtilizador == null)
                {
                    serviceResponse.Mensagem = "Dados de utilizador inválidos.";
                    serviceResponse.Sucesso = false;
                    return serviceResponse;
                }

                _context.Utilizadores.Add(newUtilizador);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = await _context.Utilizadores.ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

        // Atualizar um utilizador
        public async Task<ServiceResponse<List<Utilizador>>> UpdateUtilizador(Utilizador editUtilizador)
        {
            ServiceResponse<List<Utilizador>> serviceResponse = new ServiceResponse<List<Utilizador>>();
            try
            {
                var utilizador = await _context.Utilizadores.AsNoTracking().FirstOrDefaultAsync(x => x.UtilizadorID == editUtilizador.UtilizadorID);
                if (utilizador == null)
                {
                    serviceResponse.Mensagem = "Utilizador não encontrado.";
                    serviceResponse.Sucesso = false;
                    return serviceResponse;
                }

                _context.Utilizadores.Update(editUtilizador);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = await _context.Utilizadores.ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

        // Excluir um utilizador
        public async Task<ServiceResponse<List<Utilizador>>> DeleteUtilizador(int id)
        {
            ServiceResponse<List<Utilizador>> serviceResponse = new ServiceResponse<List<Utilizador>>();
            try
            {
                var utilizador = await _context.Utilizadores.FirstOrDefaultAsync(x => x.UtilizadorID == id);
                if (utilizador == null)
                {
                    serviceResponse.Mensagem = "Utilizador não encontrado.";
                    serviceResponse.Sucesso = false;
                    return serviceResponse;
                }

                _context.Utilizadores.Remove(utilizador);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = await _context.Utilizadores.ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }
    }
}
