using BomPagador.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BomPagador.Data.Map
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(70)")
                .IsRequired();

            builder.Property(x => x.Link)
                .HasColumnType("varchar(150)");

            builder.Property(x => x.Cnpj)
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder.Property(x => x.Vertical)
                .HasColumnType("varchar(50)")
                .IsRequired();
                
        }
    }
}
