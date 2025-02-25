﻿// <auto-generated />
using GerenciadoDespesas.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciadoDespesas.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200606005211_p1")]
    partial class p1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciadoDespesas.Models.Entities.Despesas", b =>
                {
                    b.Property<int>("DepesasId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MesId");

                    b.Property<int>("TipoDespesaId");

                    b.Property<double>("Valor");

                    b.HasKey("DepesasId");

                    b.HasIndex("MesId");

                    b.HasIndex("TipoDespesaId");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("GerenciadoDespesas.Models.Entities.Meses", b =>
                {
                    b.Property<int>("MesId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MesId");

                    b.ToTable("Meses");
                });

            modelBuilder.Entity("GerenciadoDespesas.Models.Entities.Salario", b =>
                {
                    b.Property<int>("SalarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MesId");

                    b.Property<double>("Valor");

                    b.HasKey("SalarioId");

                    b.HasIndex("MesId")
                        .IsUnique();

                    b.ToTable("Salarios");
                });

            modelBuilder.Entity("GerenciadoDespesas.Models.Entities.TipoDespesas", b =>
                {
                    b.Property<int>("TipoDespesasID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("TipoDespesasID");

                    b.ToTable("TipoDespesas");
                });

            modelBuilder.Entity("GerenciadoDespesas.Models.Entities.Despesas", b =>
                {
                    b.HasOne("GerenciadoDespesas.Models.Entities.Meses", "Meses")
                        .WithMany("Despesas")
                        .HasForeignKey("MesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GerenciadoDespesas.Models.Entities.TipoDespesas", "TipoDespesas")
                        .WithMany("Despesas")
                        .HasForeignKey("TipoDespesaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GerenciadoDespesas.Models.Entities.Salario", b =>
                {
                    b.HasOne("GerenciadoDespesas.Models.Entities.Meses", "Meses")
                        .WithOne("Salario")
                        .HasForeignKey("GerenciadoDespesas.Models.Entities.Salario", "MesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
