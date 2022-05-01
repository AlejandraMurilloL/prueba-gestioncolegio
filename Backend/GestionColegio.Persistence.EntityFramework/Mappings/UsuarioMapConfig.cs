using GestionColegio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestionColegio.Persistence.EntityFramework.Mappings
{
    class UsuarioMapConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios")
                .HasKey(o => o.Id);

            builder.Property(o => o.Id).ValueGeneratedOnAdd().HasColumnName("Id");
        }
    }
}
