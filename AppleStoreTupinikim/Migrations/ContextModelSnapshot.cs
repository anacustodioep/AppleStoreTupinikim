﻿// <auto-generated />
using AppleStoreTupinikim.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppleStoreTupinikim.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AppleStoreTupinikim.Models.ProdutoModel", b =>
                {
                    b.Property<string>("Nome")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Nome");

                    b.Property<int>("Estoque")
                        .HasColumnType("int")
                        .HasColumnName("Estoque");

                    b.Property<double>("Valor")
                        .HasColumnType("double")
                        .HasColumnName("Valor");

                    b.HasKey("Nome");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
