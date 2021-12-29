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
    public class FuncaoFuncionarioConfig : IEntityTypeConfiguration<FuncoesFuncionarios>
    {
        public void Configure(EntityTypeBuilder<FuncoesFuncionarios> builder)
        {
            builder.ToTable("FuncoesFuncionarios");
            builder.Property<Guid>("FuncionarioId").IsRequired();
            builder.Property<Guid>("FuncaoId").IsRequired();
            builder.HasKey("FuncionarioId", "FuncaoId");
        }
    }
}
