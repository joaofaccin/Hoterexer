using System;
using System.Collections.Generic;

namespace exeHotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; private set; } = new();
        public Suite Suite { get; private set; }
        public int DiasReservados { get; private set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite ?? throw new ArgumentNullException(nameof(suite), "Suite não pode ser nula.");
        }

     public void CadastrarHospede(List<Pessoa> hospedes)
{
    if (Suite == null)
    {
        Console.WriteLine("Erro: Cadastre uma suíte antes de adicionar hóspedes.");
        return;
    }

    if (hospedes == null || hospedes.Count == 0)
    {
        Console.WriteLine("Nenhum hóspede fornecido.");
        return;
    }

    Hospedes = hospedes;

    if (hospedes.Count > 2)
    {
        Console.WriteLine("Atenção: Mais de 2 hóspedes cadastrados.");
    }
}


        public int ObterQuantidadeHospedes()
        {
            return Hospedes?.Count ?? 0;
        }

        public decimal CalcularDiaria()
        {
            if (Suite == null)
            {
                throw new InvalidOperationException("Erro: Nenhuma suíte cadastrada.");
            }

            decimal valor = DiasReservados * Suite.Valor;

            if (DiasReservados >= 10)
            {
                valor *= 0.9M; // Desconto de 10%
            }

            return valor;
        }
    }
}
