// Criação da classe Ticket
using Ex01_S03;

Ticket ticket = new Ticket(new DateTime(2022, 10, 02, 20, 05, 20), DateTime.Now, false);
ticket.CalcularTempo();
ticket.CalcularValor();
Console.WriteLine($"O valor é de " + ticket.CalcularValor());