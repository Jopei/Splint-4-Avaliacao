using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão1.Tabelas
{
   
    public class Funcao
    {
       
        public Guid ID { get; set; }

        
        public string Descricao { get; set; }

      
        public int Nivel { get; set; }

        
    }
}
