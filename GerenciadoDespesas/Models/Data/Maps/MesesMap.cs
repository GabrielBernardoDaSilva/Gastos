﻿using GerenciadoDespesas.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadoDespesas.Models.Data.Maps
{
    public class MesesMap : IEntityTypeConfiguration<Meses>
    {
        public void Configure(EntityTypeBuilder<Meses> builder)
        {
            builder.HasKey(m => m.MesId);
            builder.Property(m => m.MesId).ValueGeneratedNever();
            builder.Property(m => m.Nome).HasMaxLength(50).IsRequired();

            builder.HasMany(m => m.Despesas).WithOne(m => m.Meses).HasForeignKey(m => m.MesId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(m => m.Salario).WithOne(m => m.Meses).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Meses");


        }


    }
}
