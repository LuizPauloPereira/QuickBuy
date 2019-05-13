using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);//DEfinindo chave primaria
            //Builder utiliza o padrão fluent
            builder
                .Property(u => u.Email)//Referenciando propriedade da classe
                .IsRequired() //informando que propriedade é obrigatoria para persistencia
                .HasMaxLength(50); //definindo tamanho máximo
            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);
            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .HasMany(u => u.Pedidos)//usuario tem nenhum ou vários pedidos
                .WithOne(pdd => pdd.Usuario);//pedido tem apenas 1 usuario
        }
    }
}
