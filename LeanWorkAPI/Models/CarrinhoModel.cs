using System;

namespace LeanWorkAPI.Models;

public class CarrinhoModel
{
    public int CarrinhoId { get; set; }
    public ICollection<ItemCarrinhoModel> Itens { get; set; } = new List<ItemCarrinhoModel>();
    public int TotalItens => Itens.Sum(i => i.Quantidade);
    public decimal TotalValor => Itens.Sum(i => i.PrecoTotal);
}
