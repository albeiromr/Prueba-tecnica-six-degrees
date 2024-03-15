namespace Application.Users.Responses;

/// <summary>
/// Represents the json response that the user is going to recive,
/// In this case it has the same fields as the Usuario entity, but usually
/// that´s not the case
/// </summary>
public sealed class UserResponse
{
    public int UsuId { get; init; }
    public string? Nombre { get; init; }
    public string? Apellito { get; init; }

    public UserResponse(int usuId, string? nombre, string? apellito)
    {
        UsuId = usuId;
        Nombre = nombre;
        Apellito = apellito;
    }
}
