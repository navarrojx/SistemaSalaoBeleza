using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AngelaAraujo.Models;
using System.Collections.Generic;
namespace AngelaAraujo.Models
{
    public class Atendimento
    {
        public int Id { get; set; }

        [ForeignKey("Agendamento")]
        public int IdAgendamento { get; set; } 
        public decimal ValorCobrado { get; set; }
        public decimal Desconto { get; set; }
        public string RealizadoPor { get; set; } = string.Empty;
        public DateTime RealizadoEm { get; set; }

        public Agendamento Agendamento { get; set; } = null!;

        public FormaPagamento FormaPagamento { get; set; }
    }

    public enum FormaPagamento
    {
        Pix,
        Dinheiro,
        Debito,
        Credito
    }
}
