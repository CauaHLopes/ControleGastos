
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data;

/// Contexto responsável pela comunicação entre a aplicação e o banco de dados.
public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // Tabela de pessoas.
    public DbSet<Pessoa> Pessoas { get; set; }

    // Tabela de transações.
    public DbSet<Transacao> Transacoes { get; set; }
}
