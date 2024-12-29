using System;
using System.Data.SqlClient;
using System.Web.Services;

namespace WebApplicationGestaoHotelariaWS.Services
{
    [WebService(Namespace = "http://www.ipca.pt/gestaohotelaria/cliente")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    //Cliente
    public class GestaoHotelaria : System.Web.Services.WebService
    {
        private string connectionString = "Data Source=DESKTOP-I0PFCB4\\SQLEXPRESS;Initial Catalog=GestaoHotelaria;Integrated Security=True";

        [WebMethod]
        public string CriarReserva(string email, string Quarto)
        {
            int UtilizadorID = GetUserIdByEmail(email);
            if (UtilizadorID == -1)
            {
                return "Erro: O e-mail não está registado.";
            }

            DateTime DataReserva = DateTime.Now; 
            DateTime DataEntrada = DateTime.Now.AddDays(1); // Data provisoria
            DateTime DataSaida = DataEntrada.AddDays(1); // Data provisora

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Reservas (UtilizadorID, DataReserva, DataEntrada, DataSaida, Status, Quarto) " +
                               "VALUES (@UtilizadorID, @DataReserva, @DataEntrada, @DataSaida, 'pendente', @Quarto); " +
                               "SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UtilizadorID", UtilizadorID);
                command.Parameters.AddWithValue("@DataReserva", DataReserva);
                command.Parameters.AddWithValue("@DataEntrada", DataEntrada);
                command.Parameters.AddWithValue("@DataSaida", DataSaida);
                command.Parameters.AddWithValue("@Quarto", Quarto);

                connection.Open();
                int reservationId = Convert.ToInt32(command.ExecuteScalar());
                return $"Reserva criada com sucesso! ID: {reservationId}";
            }
        }



        [WebMethod]
        public string AlterarOuCancelarReserva(int ReservaID, string justificacao, string tipoPedido, string email)
        {
            int UtilizadorID = GetUserIdByEmail(email);
            if (UtilizadorID == -1)
            {
                return "Erro: O e-mail não está registado.";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Pedidos (ReservaID, UtilizadorID, DataPedido, TipoPedido, Status, Justificacao) " +
                               "VALUES (@ReservaID, @UtilizadorID, @DataPedido, @TipoPedido, 'pendente', @Justificacao);";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReservaID", ReservaID);
                command.Parameters.AddWithValue("@UtilizadorID", UtilizadorID);
                command.Parameters.AddWithValue("@DataPedido", DateTime.Now);
                command.Parameters.AddWithValue("@TipoPedido", tipoPedido);
                command.Parameters.AddWithValue("@Justificacao", justificacao);

                connection.Open();
                command.ExecuteNonQuery();
                return $"Pedido de {tipoPedido} registado para a reserva {ReservaID}.";
            }
        }

        private int GetUserIdByEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UtilizadorID FROM Utilizadores WHERE Email = @Email";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1; 
                }
            }
        }
    }
}
