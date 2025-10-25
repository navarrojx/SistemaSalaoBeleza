using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AngelaAraujo.Models;
using System.Collections.Generic;
namespace AngelaAraujo.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        public string NomeCliente { get; set; } = null!;
        public string telefone { get; set; }
    }
}
