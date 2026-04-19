using Core.Ports.Incoming;
using Microsoft.AspNetCore.Mvc;

namespace Hexagonal.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EstoqueController(IEstoqueService service) : ControllerBase
{
    public record MovimentacaoRequest(int ProdutoId, int Quantidade);

    [HttpGet]
    public async Task<IActionResult> Listar()
    {
        var estoque = await service.ListarEstoque();
        return Ok(estoque);
    }

    [HttpPost("movimentar")]
    public async Task<IActionResult> Movimentar([FromBody] MovimentacaoRequest request)
    {
        try
        {
            await service.ExecutarMovimentacao(request.ProdutoId, request.Quantidade);
            return Ok(new { mensagem = "Movimentação realizada com sucesso" });
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { erro = ex.Message });
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(new { erro = ex.Message });
        }
    }
}
