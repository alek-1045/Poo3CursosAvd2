using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trab2.Models
{
    public class Alunos
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }

        public string Email { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
