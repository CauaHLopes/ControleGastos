using Backend.Data;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers;

/// Responsável pelas operações de cadastro de pessoas.
/// Permite criar, listar e excluir pessoas.
[ApiController]
[Route("api/[controller]")]
public class PessoaController : ControllerBase
{
    private readonly AppDbContext _context;

    public PessoaController(AppDbContext context)
    {
        _context = context;
    }

    /// Cadastra uma nova pessoa no sistema.
    [HttpPost]
    public async Task<ActionResult<Pessoa>> CriarPessoa(Pessoa pessoa)
    {
        _context.Pessoas.Add(pessoa);

        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(CriarPessoa),
            new { id = pessoa.Id },
            pessoa
        );
    }


    /// Lista todas as pessoas cadastradas.
    [HttpGet]
    public async Task<ActionResult<List<Pessoa>>> ListarPessoas()
    {
        var pessoas = await _context.Pessoas.ToListAsync();

        return Ok(pessoas);
    }
    
    /// Remove uma pessoa e todas as suas transações.
    [HttpDelete("{id}")]
    public async Task<ActionResult> ExcluirPessoa(Guid id)
    {
        var pessoa = await _context.Pessoas.FindAsync(id);

        if (pessoa == null)
        {
            return NotFound();
        }

        _context.Pessoas.Remove(pessoa);

        await _context.SaveChangesAsync();

        return NoContent();
    }
}