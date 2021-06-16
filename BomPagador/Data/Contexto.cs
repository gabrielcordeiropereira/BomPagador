using BomPagador.Data.Map;
using BomPagador.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BomPagador.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FornecedorMap());

        }
    }
}
