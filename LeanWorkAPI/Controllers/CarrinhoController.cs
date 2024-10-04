using LeanWorkAPI.DTO;
using LeanWorkAPI.Services.Carrinho;
using Microsoft.AspNetCore.Mvc;

namespace LeanWorkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrinhoController : ControllerBase
    {
        private readonly ICarrinhoInterface _carrinhoService;
        public CarrinhoController(ICarrinhoInterface carrinhoService)
        {
            _carrinhoService = carrinhoService;
        }

        [HttpGet("{idCarrinho}")]
        public async Task<IActionResult> ObterCarrinho(int idCarrinho)
        {
            var carrinho = await _carrinhoService.ObterCarrinho(idCarrinho);

            return Ok(carrinho);
        }

        [HttpPost("{idCarrinho}")]
        public async Task<IActionResult> AdicionarItem(int idCarrinho, [FromBody] RequestAdicionarItemDTO request)
        {
            var response = await _carrinhoService.AdicionarItem(idCarrinho, request);

            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpDelete("{idItem}")]
        public async Task<IActionResult> RemoverItem(int idItem)
        {
            var response = await _carrinhoService.RemoverItem(idItem);

            if (!response.Status)
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpPut("{idItem}")]
        public async Task<IActionResult> AtualizarItem(int idItem, int quantidade)
        {
            var response = await _carrinhoService.AtualizarItem(idItem, quantidade);
            if (!response.Status)
            {
                return NotFound(response);
            }

            return Ok(response);
        }

    }
}
