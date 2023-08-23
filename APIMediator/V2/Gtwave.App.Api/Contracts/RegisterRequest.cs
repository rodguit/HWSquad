 namespace Gtwave.App.Api.Contracts;
public record RegisterRequest(
    string NomeUsuario,
    string CNSCartorio,
    string Email,
    string Password
    ); 
