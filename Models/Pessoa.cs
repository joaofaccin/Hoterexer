using exeHotel.Interfaces;
using System;

namespace exeHotel.Models
{
    public class Pessoa : IPessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Documento { get; set; }
        public string Telefone { get; set; }

        public Pessoa() { }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string sobrenome, string nome)
        {
            Sobrenome = sobrenome;
            Nome = nome;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome} {Sobrenome}");
            Console.WriteLine($"Documento: {Documento}");
            Console.WriteLine($"Telefone: {Telefone}");
        }
    }
}
