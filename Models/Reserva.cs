using System;
using System.Collections.Generic;

namespace exeHotel.Models
{
  public class Reserva
  {
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados)
    {
      DiasReservados = diasReservados;
    }

    public void CadastrarHospede(List<Pessoa> hospedes)
    {
      if (Suite != null && hospedes.Count <= Suite.Capacidade)
      {
        Hospedes = hospedes;
      }
      else
      {
        throw new Exception("Número de hóspedes excede a capacidade da suíte.");
      }
    }

    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
      int quantidade = Hospedes?.Count ?? 0;

      if (quantidade > 2)
      {
        Console.WriteLine("Atenção: Mais de 2 hóspedes cadastrados.");
      }

      return quantidade;
    }

    public decimal CalcularDiaria()
    {
      decimal valor = DiasReservados * Suite.Valor;

      if (DiasReservados >= 10)
      {
        valor *= 0.9M; // Aplica 10% de desconto
      }

      return valor;
    }
  }
}
