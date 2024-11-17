using System;

namespace EventoApp.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }

        // Novo campo para o custo por participante
        public decimal CustoPorParticipante { get; set; }

        // Propriedade para calcular a duração do evento em dias
        public int DuracaoEvento => (DataTermino - DataInicio).Days;

        // Propriedade para calcular o custo total do evento
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}
