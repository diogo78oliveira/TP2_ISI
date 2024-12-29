using GestaoHotelariaAPI.Service.UtilizadorService;
using GestaoHotelariaAPI.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ISI_WebAPI.Service.UtilizadorService
{
    public class UtilizadorService : IUtilizador
    {
        private readonly string _connectionString;

        public UtilizadorService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // Obter todos os utilizadores
        public async Task<ServiceResponse<List<Utilizador>>> GetUtilizadores()
        {
            var response = new ServiceResponse<List<Utilizador>> { Dados = new List<Utilizador>() };

            try
            {
                using var connection = new SqlConnection(_connectionString);
                using var command = new SqlCommand("SELECT * FROM Utilizadores", connection);
                connection.Open();
                using var reader = await command.ExecuteReaderAsync();

                while (reader.Read())
                {
                    response.Dados.Add(new Utilizador
                    {
                        UtilizadorID = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Email = reader.GetString(2),
                        Password = reader.GetString(3),
                        Perfil = reader.GetString(4)
                    });
                }

                if (!response.Dados.Any())
                {
                    response.Mensagem = "Nenhum utilizador encontrado.";
                }
            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }

            return response;
        }

        // Obter um utilizador por ID
        public async Task<ServiceResponse<Utilizador>> GetUtilizadorById(int id)
        {
            var response = new ServiceResponse<Utilizador>();

            try
            {
                using var connection = new SqlConnection(_connectionString);
                using var command = new SqlCommand("SELECT * FROM Utilizadores WHERE UtilizadorID = @UtilizadorID", connection);
                command.Parameters.AddWithValue("@UtilizadorID", id);

                connection.Open();
                using var reader = await command.ExecuteReaderAsync();

                if (reader.Read())
                {
                    response.Dados = new Utilizador
                    {
                        UtilizadorID = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Email = reader.GetString(2),
                        Password = reader.GetString(3),
                        Perfil = reader.GetString(4)
                    };
                }
                else
                {
                    response.Mensagem = "Utilizador não encontrado.";
                    response.Sucesso = false;
                }
            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }

            return response;
        }

        // Criar um novo utilizador
        public async Task<ServiceResponse<List<Utilizador>>> CreateUtilizador(Utilizador newUtilizador)
        {
            var response = new ServiceResponse<List<Utilizador>>();

            try
            {
                using var connection = new SqlConnection(_connectionString);
                using var command = new SqlCommand(
                    "INSERT INTO Utilizadores (Nome, Email, Password, Perfil) VALUES (@Nome, @Email, @Password, @Perfil)", connection);
                command.Parameters.AddWithValue("@Nome", newUtilizador.Nome);
                command.Parameters.AddWithValue("@Email", newUtilizador.Email);
                command.Parameters.AddWithValue("@Password", newUtilizador.Password);
                command.Parameters.AddWithValue("@Perfil", newUtilizador.Perfil);

                connection.Open();
                await command.ExecuteNonQueryAsync();

                response = await GetUtilizadores(); 
            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }

            return response;
        }

        // Atualizar um utilizador
        public async Task<ServiceResponse<List<Utilizador>>> UpdateUtilizador(Utilizador editUtilizador)
        {
            var response = new ServiceResponse<List<Utilizador>>();

            try
            {
                using var connection = new SqlConnection(_connectionString);
                using var command = new SqlCommand(
                    "UPDATE Utilizadores SET Nome = @Nome, Email = @Email, Password = @Password, Perfil = @Perfil WHERE UtilizadorID = @UtilizadorID", connection);
                command.Parameters.AddWithValue("@Nome", editUtilizador.Nome);
                command.Parameters.AddWithValue("@Email", editUtilizador.Email);
                command.Parameters.AddWithValue("@Password", editUtilizador.Password);
                command.Parameters.AddWithValue("@Perfil", editUtilizador.Perfil);
                command.Parameters.AddWithValue("@UtilizadorID", editUtilizador.UtilizadorID);

                connection.Open();
                var rowsAffected = await command.ExecuteNonQueryAsync();

                if (rowsAffected == 0)
                {
                    response.Mensagem = "Utilizador não encontrado.";
                    response.Sucesso = false;
                }
                else
                {
                    response = await GetUtilizadores(); 
                }
            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }

            return response;
        }

        // Excluir um utilizador
        public async Task<ServiceResponse<List<Utilizador>>> DeleteUtilizador(int id)
        {
            var response = new ServiceResponse<List<Utilizador>>();

            try
            {
                using var connection = new SqlConnection(_connectionString);
                using var command = new SqlCommand("DELETE FROM Utilizadores WHERE UtilizadorID = @UtilizadorID", connection);
                command.Parameters.AddWithValue("@UtilizadorID", id);

                connection.Open();
                var rowsAffected = await command.ExecuteNonQueryAsync();

                if (rowsAffected == 0)
                {
                    response.Mensagem = "Utilizador não encontrado.";
                    response.Sucesso = false;
                }
                else
                {
                    response = await GetUtilizadores(); 
                }
            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }

            return response;
        }
    }
}
