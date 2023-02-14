using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_S03
{
    public class Ticket
    {
        
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set;}
        public Boolean Ativo { get; set; }

        public double valor = 0.09;
        public TimeSpan tempo;

        public Ticket(DateTime entrada, DateTime saida, Boolean ativo)
        {
            Entrada = entrada;
            Saida = saida;
            Ativo = ativo;
        }
        public void CalcularTempo()
        {
            tempo = Saida - Entrada;
            Console.WriteLine($"O tempo foi de {tempo.TotalMinutes}");
        }
        public double CalcularValor()
        {
            double calcValor;
            return calcValor = valor * tempo.TotalMinutes;
        }
    }
}
