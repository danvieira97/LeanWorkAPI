using System;

namespace LeanWorkAPI.Models;

public class ItemCarrinhoModel
{
    public int Id { get; set; }
    public int CarrinhoId { get; set; }
    public required string Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public decimal PrecoTotal => Quantidade * PrecoUnitario;

}