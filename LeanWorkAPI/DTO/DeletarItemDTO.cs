using System;

namespace LeanWorkAPI.DTO;

public class ResponseDeletarItemDTO
{
    public string Mensagem { get; set; } = "Item removido com sucesso";

    public bool Status { get; set; } = true;
}
