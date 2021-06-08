using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BomPagador.Models
{
    public class Fatura
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Vertical Vertical { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime Vencimento { get; set; }

    }
}
