﻿// <auto-generated />
using LanchesMac.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
#nullable disable

namespace LanchesMac.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220822003930_MigracaoInicial")]
    partial class primeira
    {
        protected void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Site_loja.Models.Categoria", b =>
            {
                b.Property<int>("categoriaId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("categoriaId"), 1L, 1);

                b.Property<string>("categorianome")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("descricao")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("categoriaId");

                b.ToTable("Categorias");
            });

            modelBuilder.Entity("Site_loja.Models.Lanche", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("DescricaoCurta")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("DescricaoLonga")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ImgThumbnails")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ImgUrl")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsEstoque")
                    .HasColumnType("bit");

                b.Property<bool>("IsPreferido")
                    .HasColumnType("bit");

                b.Property<string>("Nome")
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("Preco")
                    .HasColumnType("decimal(18,2)");

                b.Property<int>("categoriaId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("categoriaId");

                b.ToTable("Lanches");
            });

            modelBuilder.Entity("Site_loja.Models.Lanche", b =>
            {
                b.HasOne("Site_loja.Models.Categoria", "categoria")
                    .WithMany("lanches")
                    .HasForeignKey("categoriaId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("categoria");
            });

            modelBuilder.Entity("Site_loja.Models.Categoria", b =>
            {
                b.Navigation("lanches");
            });
#pragma warning restore 612, 618
        }
    }
}