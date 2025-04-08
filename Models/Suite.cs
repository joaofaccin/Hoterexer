namespace exeHotel.Models
{
  public class Suite
  {
    public string TipoSuite { get; set; }
    public int Capacidade { get; set; }
    public decimal Valor { get; set; }

    public Suite() { }

    public Suite(string tipoSuite, int capacidade, decimal valor)
    {
      TipoSuite = tipoSuite;
      Capacidade = capacidade;
      Valor = valor;
    }
  }
}