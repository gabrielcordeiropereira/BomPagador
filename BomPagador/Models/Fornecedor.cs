using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BomPagador.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Link { get; set; }
        public string Cnpj { get; set; }
        public Vertical Vertical { get; set; }
        
    }
    public enum Vertical
    {
        agua = 1,
        energia = 2,
        condominio = 3,
        telecom = 4,
    }

}
