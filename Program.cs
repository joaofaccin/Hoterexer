using System.Text;
using exeHotel.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cabeçalho bonito
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("=== Sistema de Reservas de Hotel ===\n");
Console.ResetColor();

// Criação de hóspedes
List<Pessoa> hospedes = new List<Pessoa>
{
    new Pessoa(nome: "Hospede 1"),
    new Pessoa(nome: "Hospede 2")
};

// Criação da suíte e reserva
Suite suite = new Suite(tipoSuite: "Suíte Luxo", capacidade: 2, valor: 30);
Reserva reserva = new Reserva(diasReservados: 10);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospede(hospedes);

// Verificação de capacidade e exibição
int qtdHospedes = reserva.ObterQuantidadeHospedes();
Console.WriteLine("\n--- Detalhes da Reserva ---");

if (qtdHospedes > suite.Capacidade)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("❌ Erro: Capacidade da suíte excedida. Reserva inválida.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"✅ Hóspedes cadastrados: {qtdHospedes}");
    Console.WriteLine($"🏨 Capacidade da suíte: {suite.Capacidade}");

    Console.WriteLine("👥 Lista de hóspedes:");
    foreach (var hospede in hospedes)
    {
        Console.WriteLine($"- {hospede.Nome} {hospede.Sobrenome}");
    }

    Console.WriteLine($"🏨 Tipo da suíte: {suite.TipoSuite}");
    Console.WriteLine($"💰 Valor total da reserva: R$ {reserva.CalcularDiaria():F2}");
    Console.ResetColor();
}

Console.WriteLine("\n=============================\n");

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();