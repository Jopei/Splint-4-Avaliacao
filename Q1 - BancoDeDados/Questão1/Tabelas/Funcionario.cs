using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão1.Tabelas
{
 
    public class Funcionario
    {
       
        public Guid Id { get; set; }
        
        public string Nome { get; set; }
       
        public DateTime DataNascimento { get; set; }
        public Guid CidadeId { get; set; }



    }
}
