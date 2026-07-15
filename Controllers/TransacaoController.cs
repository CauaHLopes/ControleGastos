
using Backend.Data;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers;

/// Responsável pelas operações de transações.
[ApiController]
[Route("api/[controller]")]
public class TransacaoController : ControllerBase
{
    private readonly AppDbContext _context;

    public TransacaoController(AppDbContext context)
    {
        _context = context;
    }

    /// Cadastra uma transação.
    [HttpPost]
    public async Task<ActionResult<Transacao>> CriarTransacao(
        Transacao transacao)
    {
        var pessoa = await _context.Pessoas
            .FindAsync(transacao.PessoaId);

        if (pessoa == null)
        {
            return BadRequest("Pessoa não encontrada.");
        }

        // Menores de idade só podem cadastrar despesas.
        if (pessoa.Idade < 18 &&
            transacao.Tipo == TipoTransacao.Receita)
        {
            return BadRequest(
                "Menores de idade não podem cadastrar receitas.");
        }

        _context.Transacoes.Add(transacao);

        await _context.SaveChangesAsync();

        return Ok(transacao);
    }

    /// Lista todas as transações.
    [HttpGet]
    public async Task<ActionResult<List<Transacao>>> Listar()
    {
        var transacoes = await _context.Transacoes
            .Include(t => t.Pessoa)
            .ToListAsync();

        return Ok(transacoes);
    }
}
