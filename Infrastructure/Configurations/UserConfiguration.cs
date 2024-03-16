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

        builder.Property(user => user.UsuID)
            .HasColumnName("usuID")
            .HasColumnType("numeric(18,0)");

        builder.Property(user => user.Nombre)
            .HasColumnName("nombre")
            .HasColumnType("varchar(100)");

        builder.Property(user => user.Apellido)
            .HasColumnName("apellido")
            .HasColumnType("varchar(100)");
    }
}
