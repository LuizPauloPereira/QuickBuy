using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(pdd=>pdd.Id);
            builder
                .Property(pdd => pdd.DataPedido)
                .IsRequired();
            /*builder
                .Property(pdd => pdd.UsuarioId)
                .IsRequired()
                .HasMaxLength(10);*/
            builder
                .Property(pdd => pdd.DataPrevisaoEntrega)
                .IsRequired();
            builder
                .Property(pdd => pdd.CEP)
                .IsRequired()
                .HasMaxLength(10);
            builder
                .Property(pdd => pdd.Estado)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(pdd => pdd.Cidade)
                .IsRequired()
                .HasMaxLength(80);
            builder
                .Property(pdd => pdd.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(100);
            //builder.HasOne(p => p.Usuario); //Pedido tem apenas 1 Usuario (redundancia de mapeamento)
            /*builder
                .Property(pdd => pdd.NumeroEndereco)
                .IsRequired()
                .HasMaxLength(10);
            builder
                .Property(pdd => pdd.FormaPagamentoId)
                .IsRequired()
                .HasMaxLength(1);*/
            //builder.Property(pdd => pdd.FormaPagamento);
            //builder.Property(pdd => pdd.ItensPedido);
        }
    }
}
