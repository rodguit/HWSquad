namespace Gtwave.App.Api.Contracts;
public record AuthenticatiAppesponse(
    int Id,
    string NomeUsuario,
    string CNSCartorio,
    string Email,
    string Token);