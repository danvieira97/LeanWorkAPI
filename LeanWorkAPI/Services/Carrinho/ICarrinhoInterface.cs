using System;
using LeanWorkAPI.DTO;
using LeanWorkAPI.Models;

namespace LeanWorkAPI.Services.Carrinho;

public interface ICarrinhoInterface
{
    //Criar Carrinho
    Task<CarrinhoModel> CriarCarrinho();
    Task<CarrinhoModel> ObterCarrinho(int idCarrinho);
    Task<ResponseAdicionarItemDTO> AdicionarItem(int idCarrinho, RequestAdicionarItemDTO request);
    Task<ResponseDeletarItemDTO> RemoverItem(int idItem);
    Task<ResponseAtualizarItemDTO> AtualizarItem(int id, int quantidade);
}
