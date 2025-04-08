using System.Diagnostics.Contracts;
using System.Text;
using exeHotel.Models;


Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();


Pessoa p1 = new Pessoa(nome: "Hospede 1");
Pessoa p2 = new Pessoa(nome: "Hospede 2");
Pessoa p3 = new Pessoa(nome: "Hospede 3");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

Suite suite = new Suite(tipoSuite: "Suite 1", capacidade: 2, valor: 30);


Reserva reserva = new Reserva(diasReservados: 10);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospede(hospedes);

Console.WriteLine($"Hóspedes:{reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Diária:{reserva.CalcularDiaria()}");