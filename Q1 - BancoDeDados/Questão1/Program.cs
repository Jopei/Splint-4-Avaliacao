using Questão1.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Questão1.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;



namespace Questão1
{
    internal class Program
    {
        static void Main(string[] args)//exibir funcionarios 
        {
            string sql = "SELECT Id, Nome, DataNascimento, CidadeId, UltimaAtualizacao FROM VW_All_Funcionarios";
            var contexto = new CidadesContexto();
            //ADD_CIDADE(contexto);
            var lista = contexto._VW_All_Funcionarios.FromSql(sql);// contexto._VW_All_Funcionarios.FromSqlRaw(sql);
            foreach (var funcionario in contexto._VW_All_Funcionarios)
            {
                Console.WriteLine(funcionario.Nome);
            }
            Console.WriteLine("Fim da Lista");

        }

        static void ADD_CIDADE(CidadesContexto add)//add cidades
        {
            string comando = "DECLARE @P_Id uniqueidentifier; SET @P_Id = NEWID();" +
               "exec SP_ADD_CIDADE " + "@P_Id, " +"@P_Nome, " +"@P_Populacao, " + "@P_TaxaCriminalidade, " +               "@P_ImpostoSobreProduto, " +
               "@P_EstadoCalamidade";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@P_Nome", Value = "São Paulo 2"},
                new SqlParameter{ParameterName = "@P_Populacao", Value = 1},
                new SqlParameter{ParameterName = "@P_TaxaCriminalidade", Value = 1},
                new SqlParameter{ParameterName = "@P_ImpostoSobreProduto", Value = 1},
                new SqlParameter{ParameterName = "@P_EstadoCalamidade", Value = 0},
            };
            var retorno = add.Database.ExecuteSqlCommand(comando, parameters);
            Console.WriteLine("Cidade Incluida");
        }

    }
}
