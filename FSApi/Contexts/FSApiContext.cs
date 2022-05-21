using FSApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FSApi.Contexts
{
    public class FSApiContext : DbContext
    {
        public FSApiContext()
        {
        }

        public FSApiContext(DbContextOptions<FSApiContext> options) : base(options)
        {
        }

        protected override void

           OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-PH8GVRC\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
