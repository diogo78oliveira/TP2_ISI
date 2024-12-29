using System;

public class HistoricoItem
{
    public int HistoricoID { get; set; }
    public int ReservaID { get; set; }
    public DateTime DataAlteracao { get; set; }
    public string AcaoRealizada { get; set; }
    public int UtilizadorID { get; set; }
}
