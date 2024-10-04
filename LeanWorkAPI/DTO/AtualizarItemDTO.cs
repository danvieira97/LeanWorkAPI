using System;
using LeanWorkAPI.Models;

namespace LeanWorkAPI.DTO;

public class ResponseAtualizarItemDTO
{
    public string Mensagem { get; set; } = "Item atualizado com sucesso";

    public bool Status { get; set; } = true;
    public ItemCarrinhoModel? Item { get; set; }
}