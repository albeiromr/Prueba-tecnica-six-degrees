using Domain.Commons.Abstractions;

namespace Domain.Users;

public sealed class Usuario : Entity
{
    public string? Nombre { get; private set; }
    public string? Apellido { get; private set; }

    // this constructor is required for executing migrations with 
    // entity framework under the domain driven design architecture
    private Usuario() { }

    // this constructor is private for protecting the entity from external access
    private Usuario(int usuId, string? nombre, string? apellido) : base(usuId)
    {
        Nombre = nombre;
        Apellido = apellido;
    }

    /// <summary>
    /// Generates a new instance of the Usuario entity
    /// </summary>
    public static Usuario Create(int dbUsersAmount, string? nombre, string? apellido)
    {
        var newId = dbUsersAmount += 1;
        return new Usuario(newId, nombre, apellido);
    }
}
