namespace GestaoHotelariaAPI.Models
{
    public class Reserva
    {
        public int ReservaID { get; set; }
        public int UtilizadorID { get; set; }
        public DateTime DataReserva { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public string Status { get; set; }
        public string Quarto { get; set; }

        public Utilizador Utilizador { get; set; }

    }
}
