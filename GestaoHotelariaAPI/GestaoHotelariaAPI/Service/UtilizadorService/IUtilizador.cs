using GestaoHotelariaAPI.Models;

namespace GestaoHotelariaAPI.Service.UtilizadorService
{
    public interface IUtilizador
    {
        Task<ServiceResponse<List<Utilizador>>> GetUtilizadores();
        Task<ServiceResponse<Utilizador>> GetUtilizadorById(int id);
        Task<ServiceResponse<List<Utilizador>>> CreateUtilizador(Utilizador newUtilizador);
        Task<ServiceResponse<List<Utilizador>>> UpdateUtilizador(Utilizador editUtilizador);
        Task<ServiceResponse<List<Utilizador>>> DeleteUtilizador(int id);
    }
}
