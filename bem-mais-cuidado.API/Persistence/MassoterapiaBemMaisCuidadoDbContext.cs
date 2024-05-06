using bem_mais_cuidado.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace bem_mais_cuidado.API.Persistence
{
    public class MassoterapiaBemMaisCuidadoDbContext : DbContext
    {
        public MassoterapiaBemMaisCuidadoDbContext(DbContextOptions<MassoterapiaBemMaisCuidadoDbContext> options) : base(options)
        {
            //AgendamentosBemMaisCuidado = new List<AgendamentoBemMaisCuidado>();

            //Agendas = [];
            //Agendamentos = [];
        }

        /// <summary>
        /// DbSet's irão corresponder como se fossem tabelas.
        /// </summary>
        public DbSet<AgendaBemMaisCuidado> Agendas { get; set; }
        public DbSet<AgendamentoBemMaisCuidado> Agendamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AgendamentoBemMaisCuidado>(e =>
            {
                e.HasKey(ag => ag.Id);

                e.Property(ag => ag.Titulo).IsRequired(false);

                e.Property(ag => ag.HorarioInicial)
                    .HasColumnName("Horario_Inicial");

                e.Property(ag => ag.HorarioFinal)
                    .HasColumnName("Horario_Final");

               // e.HasMany(ag => ag.agen)
            });

            builder.Entity<AgendaBemMaisCuidado>(e =>
            {
                e.HasKey(ag => ag.Id);
            });
        }

    }
}
