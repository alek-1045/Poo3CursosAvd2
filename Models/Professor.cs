using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace trab2.Models
{
    public class Professor
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]

        public string Nome { get; set; }

        public int Telefone { get; set; }

        public string Formação { get; set; }

        public string Email { get; set; }

        public Categoria Categoria { get; set; }
    }
}
