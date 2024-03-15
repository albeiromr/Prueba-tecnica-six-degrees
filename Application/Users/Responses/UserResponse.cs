namespace Application.Users.Responses;

/// <summary>
/// Represents the json response that the user recives
/// </summary>
public sealed class UserResponse
{
    public int UsuId { get; init; }
    public string? Nombre { get; init; }
    public string? Apellido { get; init; }
}
