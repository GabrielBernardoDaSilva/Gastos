using GerenciadoDespesas.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadoDespesas.Models.Data.Maps
{
    public class SalarioMap : IEntityTypeConfiguration<Salario>
    {

        public void Configure(EntityTypeBuilder<Salario> builder)
        {
            builder.HasKey(s => s.SalarioId);
            builder.Property(s => s.Valor).IsRequired();

            builder.HasOne(s => s.Meses).WithOne(s => s.Salario).HasForeignKey<Salario>(s => s.MesId);

            builder.ToTable("Salarios");
        }
    }
}
