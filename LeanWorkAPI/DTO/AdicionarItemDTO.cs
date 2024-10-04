using System;
using LeanWorkAPI.Models;

namespace LeanWorkAPI.DTO;

public class RequestAdicionarItemDTO
{
    public required string Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
}

public class ResponseAdicionarItemDTO
{
    public string Mensagem { get; set; } = "Item adicionado com sucesso";

    public bool Status { get; set; } = true;
    public ItemCarrinhoModel? Item { get; set; }
}