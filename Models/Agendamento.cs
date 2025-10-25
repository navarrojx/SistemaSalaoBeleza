
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AngelaAraujo.Models;
using System.Collections.Generic;
namespace AngelaAraujo.Models
{
    public class Agendamento
    {

        [Key]
        public int idAgendamento { get; set; }

        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }

        public DateTime dataHoraInicio { get; set; }
        public DateTime dataHoraFim { get; set; }

        public StatusAgendamento Status { get; set; } = StatusAgendamento.Agendado;
        public DateTime criadoPor { get; set; }
        public string Observacoes { get; set; }

        public List<Atendimento> Atendimentos { get; set; } = new();

        // coleção de serviços (muitos para muitos)
        public ICollection<Servico> Servicos { get; set; } = new List<Servico>();
        public ICollection<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();

        // Relacionamentos
        public Atendimento? atendimento { get; set; }
        public Cliente? Cliente { get; set; }

    }
    public enum StatusAgendamento
    {
        Agendado = 0,
        Concluido = 1

    }
}






