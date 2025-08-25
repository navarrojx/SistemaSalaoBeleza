using Microsoft.EntityFrameworkCore;
using AngelaAraujo;
using AngelaAraujo.Models;

namespace AngelaAraujo
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Agendamento>().ToTable("Agendamento");
            modelBuilder.Entity<Atendimento>().ToTable("Atendimento");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Servico>().ToTable("Servico");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");

            modelBuilder.Entity<Atendimento>()
                    .Property(a => a.ValorCobrado)
                    .HasPrecision(18, 2);
            modelBuilder.Entity<Atendimento>()
                .HasOne(p => p.Agendamento)
                .WithMany(a => a.Atendimentos)
                .HasForeignKey(p => p.IdAgendamento);

            modelBuilder.Entity<Agendamento>()
            .HasMany(a => a.Servicos)             // plural
            .WithMany(s => s.Agendamentos)        // plural no Servico
            .UsingEntity<Dictionary<string, object>>(
                "AgendamentoServico",             // tabela de junção
                j => j.HasOne<Servico>().WithMany().HasForeignKey("ServicoId"),
                j => j.HasOne<Agendamento>().WithMany().HasForeignKey("AgendamentoId")
            );

        }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Atendimento> Atendimento { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<Usuario> Pagamentos { get; set; }
    }
}
