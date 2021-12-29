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
    public class FuncionarioConfig : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionarios");

            builder
                .Property(a => a.Id)
                .HasColumnName("Id")
                .IsRequired();
            builder
                 .Property(a => a.Nome)
                .HasColumnName("Nome");
            builder
                .Property(a => a.DataNascimento)
                .HasColumnName("DataNascimento")
                .IsRequired();
            builder
                .Property<DateTime?>("UltimaAtualizacao");
            //builder
            //    .HasOne(a => a.Cidades)
            //    .WithOne(fa => a.)
              
        }
    }
}
