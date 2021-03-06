using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trab2.Models
{
    public class Context : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Professor> Professors { get; set; }

        public DbSet<Alunos> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString:@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True");
        }
    }
}
