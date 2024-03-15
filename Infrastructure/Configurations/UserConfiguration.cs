using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

/// <summary>
/// Contains the database table configuration and constraints for the Usuario entity
/// </summary>
internal sealed class UserConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario");
        builder.HasKey(user => user.UsuID);
        builder.Property(user => user.Nombre);
        builder.Property(user => user.Apellido);
    }
}
