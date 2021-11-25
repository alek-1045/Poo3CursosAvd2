using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace trab2.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo descrição é obrigatória")]

        public string Descricao { get; set; }

        public List<Professor> Professors { get; set; }
    }
}
