namespace Backend.Models;

/// Representa uma pessoa cadastrada no sistema.
/// Cada pessoa pode possuir uma ou mais transações financeiras.
public class Pessoa
{
    // Identificador da pessoa.
    public Guid Id { get; set; }

    // Nome completo da pessoa.
    public string Nome { get; set; } = string.Empty;

    // Idade utilizada para validação das regras de negócio.
    public int Idade { get; set; }


    /// Transações associadas à pessoa.
    public List<Transacao> Transacoes { get; set; } = [];

}
