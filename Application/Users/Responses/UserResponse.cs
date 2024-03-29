﻿namespace Application.Users.Responses;

/// <summary>
/// Represents the json response that the user is going to recive,
/// In this case it has the same fields as the Usuario entity, but usually
/// that´s not the case
/// </summary>
public sealed class UserResponse
{
    public int UsuID { get; init; }
    public string? Nombre { get; init; }
    public string? Apellido { get; init; }

    public UserResponse(int usuId, string? nombre, string? apellido)
    {
        UsuID = usuId;
        Nombre = nombre;
        Apellido = apellido;
    }
}
