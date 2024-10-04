using System;

namespace LeanWorkAPI.Models;

public class ResponseModel<T>
{
    public T? Dados { get; set; }
    public string Mensagem { get; set; } = string.Empty;
    public bool Sucesso { get; set; }
}
