using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão1.Tabelas
{
    
    public class Cidade
    {
        
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public int População { get; set; }
        public double TaxaCriminalidade{ get; set; }
        public double ImpostoSobreProduto { get; set; }
        public bool EstadoDeCalamidade { get; set; }
        public override string ToString()
        {
            return $"Cidade ({ID}): {Nome}";
        }


    }

}
