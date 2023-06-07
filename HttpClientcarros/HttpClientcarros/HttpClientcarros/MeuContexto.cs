using HttpClientcarros;
using Microsoft.EntityFrameworkCore;

public class MeuContexto : DbContext
{
    public DbSet<veiculo> Veiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configura a conexão com o banco de dados
        optionsBuilder.UseSqlServer("sua-string-de-conexao-com-o-banco-de-dados");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configura o mapeamento das entidades para as tabelas do banco de dados
        modelBuilder.Entity<veiculo>()
            .ToTable("Veiculos")
            .HasKey(v => v.Id); // Supondo que a classe veiculo tenha uma propriedade Id como chave primária
    }
}
