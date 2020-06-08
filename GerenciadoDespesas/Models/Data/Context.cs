using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadoDespesas.Models.Entities;
using GerenciadoDespesas.Models.Data.Maps;

namespace GerenciadoDespesas.Models.Data
{
    public class Context : DbContext
    {
        public DbSet<Meses> Meses { get; set; }
        public DbSet<Salario> Salarios { get; set; }
        public DbSet<Despesas> Despesas { get; set; }
        public DbSet<TipoDespesas> TipoDespesas { get; set; }


        public Context(DbContextOptions<Context> option):base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TipoDespesasMap());
            modelBuilder.ApplyConfiguration(new MesesMap());
            modelBuilder.ApplyConfiguration(new SalarioMap());
            modelBuilder.ApplyConfiguration(new DespesasMap());
        }

    }
}
