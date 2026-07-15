
namespace Backend.Models;

/// Representa uma movimentação financeira associada a uma pessoa.
public class Transacao
{
    // Identificador da transação.
    public Guid Id { get; set; }

    // Descrição informada pelo usuário.
    public string Descricao { get; set; } = string.Empty;

    // Valor da transação.
    public decimal Valor { get; set; }

    // Tipo da transação: Receita ou Despesa.
    public TipoTransacao Tipo { get; set; }

    // Identificador da pessoa à qual a transação pertence.
    public Guid PessoaId { get; set; }


    /// Pessoa proprietária da transação.
    public Pessoa Pessoa { get; set; } = null!;

}
