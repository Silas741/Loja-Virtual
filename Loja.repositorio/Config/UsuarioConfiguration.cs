using Loja.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(u => u.Nome).IsRequired().HasMaxLength(25);
            builder.Property(u => u.Sobrenome).IsRequired().HasMaxLength(25);
            builder.Property(u => u.Senha).IsRequired().HasMaxLength(20);
            //um pedido para muitos Usuarios
            builder.HasMany(u => u.pedidos)
                .WithOne(p => p.usuario);           
        }
    }
}
