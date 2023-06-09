﻿using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);

            builder
                .Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(f => f.Descricao)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}
