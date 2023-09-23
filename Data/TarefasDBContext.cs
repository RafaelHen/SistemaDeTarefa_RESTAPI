using Microsoft.EntityFrameworkCore;
using SistemaDeTarefa.Data.Map;
using SistemaDeTarefa.Models;

namespace SistemaDeTarefa.Data
{
    public class TarefasDBContext : DbContext
    {
        public TarefasDBContext(DbContextOptions<TarefasDBContext> options) : base(options)
        {   
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
