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
    public class FuncaoConfig : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.ToTable("Funcoes");

            builder
                .Property(a => a.ID)
                .HasColumnName("Id")
                .IsRequired();
            builder
                 .Property(a => a.Descricao)
                .HasColumnName("Descricao");
            builder
                .Property(a => a.Nivel)
                .HasColumnName("NivelAcesso")
                .IsRequired();

            builder
                .Property<DateTime?>("UltimaAtualizacao");
        }
    }
}
