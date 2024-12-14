namespace GestaoHotelariaAPI.Models
{
    public class Historico
    {
        public int HistoricoID { get; set; }
        public int ReservaID { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string AcaoRealizada { get; set; }
        public int UtilizadorID { get; set; }

        public Reserva Reserva { get; set; }
        public Utilizador Utilizador { get; set; }
    }
}
