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
    internal class PrefeitoConfig : IEntityTypeConfiguration<Prefeito>
    {
        public void Configure(EntityTypeBuilder<Prefeito> builder)
        {
            builder.ToTable("PrefeitosAtuais");

            builder
                .Property(a => a.Id)
                .HasColumnName("Id")
                .IsRequired();
            builder
                 .Property(a => a.Nome)
                .HasColumnName("Nome");
            builder
                .Property(a => a.InicioMandato)
                .HasColumnName("InicioMandato")
                .IsRequired();
            builder
                .Property(a => a.FimMandato)
                .HasColumnName("FimMandato")
                .IsRequired();
            
            builder
                .Property<DateTime?>("UltimaAtualizacao");
        }
    }
}
