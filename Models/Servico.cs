using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AngelaAraujo.Models;
using System.Collections.Generic;
namespace AngelaAraujo.Models
{
    public class Servico
    {
        [Key]
         public int IdServico { get; set; }
         public string Name { get; set; } = null!;
         
         public string descricao { get; set; }  
            
        
         public TimeSpan duracaoMinutos { get; set; }
         public double preco { get; set; }

        public ICollection<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();
        //Relacionamento 

            

    }
}
