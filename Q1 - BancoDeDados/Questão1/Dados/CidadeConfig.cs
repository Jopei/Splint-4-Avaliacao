using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questão1.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão1.Dados
{
    public class CidadeConfig : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("Cidades");

            builder
                .Property(a => a.ID)
                .HasColumnName("Id")
                 .IsRequired();
            builder
                 .Property(a => a.Nome)
                .HasColumnName("Nome");
            builder
                .Property(a => a.População)
                .HasColumnName("Populacao")
                .IsRequired();
            builder
                .Property(a => a.TaxaCriminalidade)
                .HasColumnName("TaxaCriminalidade")
                .IsRequired();
            builder
                .Property(a => a.ImpostoSobreProduto)
                .HasColumnName("ImpostoSobreProduto")
                .IsRequired();
            builder
                .Property(a => a.EstadoDeCalamidade)
                .HasColumnName("EstadoCalamidade")
                .IsRequired();

            builder
                .Property<DateTime?>("UltimaAtualizacao");
                
        }
    }
}
