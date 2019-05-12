using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetosDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(fpgt=>fpgt.Id);
            builder
                .Property(fpgt => fpgt.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(fpgt => fpgt.Descricao)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
