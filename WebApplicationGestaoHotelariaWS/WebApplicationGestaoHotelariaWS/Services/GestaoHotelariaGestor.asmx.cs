using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Services;

namespace WebApplicationGestaoHotelariaWS.Services
{
    [WebService(Namespace = "http://www.ipca.pt/gestaohotelaria/gestor")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class GestaoHotelariaGestor : System.Web.Services.WebService
    {
        private string connectionString = "Data Source=DESKTOP-I0PFCB4\\SQLEXPRESS;Initial Catalog=GestaoHotelaria;Integrated Security=True";

        [WebMethod]
        public string AprovarReserva(int ReservaID)
        {
            DateTime DataEntrada = DateTime.Now; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Reservas SET DataEntrada = @DataEntrada, Status = 'aprovada' WHERE ReservaID = @ReservaID AND Status = 'pendente'";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReservaID", ReservaID);
                command.Parameters.AddWithValue("@DataEntrada", DataEntrada);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return $"Reserva {ReservaID} aprovada com sucesso. Data de entrada: {DataEntrada}.";
                }
                else
                {
                    return $"Erro: A reserva {ReservaID} não foi encontrada ou já foi aprovada.";
                }
            }
        }


        [WebMethod]
        public string AprovarOuRejeitarPedido(int PedidoID, bool isApproved)
        {
            string status = isApproved ? "aceite" : "rejeitado";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Pedidos SET Status = @Status WHERE PedidoID = @PedidoID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PedidoID", PedidoID);
                command.Parameters.AddWithValue("@Status", status);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return $"Pedido {PedidoID} foi atualizado para {status}.";
                }
                else
                {
                    return $"Erro: Pedido {PedidoID} não encontrado.";
                }
            }
        }

        [WebMethod]
        public string ConcluirReserva(int ReservaID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
       
                        string updateQuery = "UPDATE Reservas SET Status = 'concluída', DataSaida = @DataSaida WHERE ReservaID = @ReservaID";

                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction);
                        updateCommand.Parameters.AddWithValue("@ReservaID", ReservaID);
                        updateCommand.Parameters.AddWithValue("@DataSaida", DateTime.Now); 

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            throw new Exception($"Erro: Reserva {ReservaID} não encontrada.");
                        }

                        string insertHistoricoQuery = @"
                    INSERT INTO Historico (ReservaID, DataAlteracao, AcaoRealizada, UtilizadorID)
                    SELECT @ReservaID, @DataAlteracao, 'Reserva concluída', UtilizadorID
                    FROM Reservas
                    WHERE ReservaID = @ReservaID";

                        SqlCommand insertHistoricoCommand = new SqlCommand(insertHistoricoQuery, connection, transaction);
                        insertHistoricoCommand.Parameters.AddWithValue("@ReservaID", ReservaID);
                        insertHistoricoCommand.Parameters.AddWithValue("@DataAlteracao", DateTime.Now); 

                        insertHistoricoCommand.ExecuteNonQuery();

                        transaction.Commit();

                        return $"Reserva {ReservaID} concluída com sucesso. Data de saída: {DateTime.Now}";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return $"Erro ao concluir a reserva {ReservaID}: {ex.Message}";
                    }
                }
            }
        }

    }
}
