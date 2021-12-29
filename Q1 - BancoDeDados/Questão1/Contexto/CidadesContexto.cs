using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Data.SqlClient;

using Questão1.Tabelas;
using System;

namespace Questão1.Dados
{
    internal class CidadesContexto : DbContext //Mapeamento dos Elementos do banco de dados
    {
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<Prefeito> Prefeitos { get; set; }
        public DbSet<FuncoesFuncionarios> FuncoesEFuncionarios { get; set; }
        public DbSet<VW_ALL_FUNCIONARIOS> _VW_All_Funcionarios { get; set; }
        //public DbSet<SP_ADD_CIDADE> Addcidade { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database=Cidades; Trusted_connection = true; ");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CidadeConfig());
            modelBuilder.ApplyConfiguration(new FuncaoConfig());
            modelBuilder.ApplyConfiguration(new FuncionarioConfig());
            modelBuilder.ApplyConfiguration(new PrefeitoConfig());
            modelBuilder.ApplyConfiguration(new FuncaoFuncionarioConfig());
        }
    }
}
