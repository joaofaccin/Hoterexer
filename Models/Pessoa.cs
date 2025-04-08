namespace exeHotel.Models
{
  public class Pessoa
  {
    public string Nome { get; set; }
    public string SobreNome { get; set; }

    public Pessoa() { }
    public Pessoa(string nome)
    {
      Nome = nome;
    }
    public Pessoa(string sobreNome, string nome)
    {
      SobreNome = sobreNome;
      Nome = nome;
    }
  }
}