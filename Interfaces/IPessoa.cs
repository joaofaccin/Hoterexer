namespace exeHotel.Interfaces
{
  public interface IPessoa
  {
    string Nome { get; set; }
    string Documento { get; set; }
    string Telefone { get; set; }

    void ExibirInformacoes();
  }
}