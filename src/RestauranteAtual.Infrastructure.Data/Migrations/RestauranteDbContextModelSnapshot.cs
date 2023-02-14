﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestauranteAtual.Infrastructure.Data;

#nullable disable

namespace RestauranteAtual.Infrastructure.Data.Migrations
{
    [DbContext(typeof(RestauranteDbContext))]
    partial class RestauranteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestauranteAtual.Domain.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("BAIRRO");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar")
                        .HasColumnName("CEP");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar")
                        .HasColumnName("CPF");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("CIDADE");

                    b.Property<DateTime?>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("datetime")
                        .HasColumnName("DATANASCIMENTO");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("ENDERECO");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("ESTADO");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("char")
                        .HasColumnName("GENERO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("NOME");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("NUMERO");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("PAIS");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar")
                        .HasColumnName("RG");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CLIENTE", (string)null);
                });

            modelBuilder.Entity("RestauranteAtual.Domain.Garcom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime")
                        .HasColumnName("DATAADMISSAO");

                    b.Property<int>("Idade")
                        .HasColumnType("int")
                        .HasColumnName("IDADE");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("NOME");

                    b.HasKey("Id");

                    b.ToTable("GARCOM", (string)null);
                });

            modelBuilder.Entity("RestauranteAtual.Domain.ItensPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGarcom")
                        .HasColumnType("int");

                    b.Property<int>("IdPedido")
                        .HasColumnType("int");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("QUANTIDADE");

                    b.Property<decimal>("ValorItem")
                        .HasPrecision(7, 2)
                        .HasColumnType("decimal")
                        .HasColumnName("VALORITEM");

                    b.HasKey("Id");

                    b.HasIndex("IdGarcom")
                        .IsUnique();

                    b.HasIndex("IdPedido")
                        .IsUnique();

                    b.HasIndex("IdProduto")
                        .IsUnique();

                    b.ToTable("ITENSPEDIDO", (string)null);
                });

            modelBuilder.Entity("RestauranteAtual.Domain.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdRestaurante")
                        .HasColumnType("int");

                    b.Property<string>("Localizacao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("LOCALIZACAO");

                    b.Property<int>("NumeroDaMesa")
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasColumnName("NUMERODAMESA");

                    b.HasKey("Id");

                    b.HasIndex("IdRestaurante")
                        .IsUnique();

                    b.ToTable("MESA", (string)null);
                });

            modelBuilder.Entity("RestauranteAtual.Domain.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime")
                        .HasColumnName("DATA");

                    b.Property<string>("FormaPagamento")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("FORMAPAGAMENTO");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdMesa")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeDeItens")
                        .HasColumnType("int")
                        .HasColumnName("QUANTIDADEDEITENS");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("STATUS");

                    b.Property<decimal>("Valor")
                        .HasPrecision(7, 2)
                        .HasColumnType("decimal")
                        .HasColumnName("VALOR");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente")
                        .IsUnique();

                    b.HasIndex("IdMesa")
                        .IsUnique();

                    b.ToTable("PEDIDO", (string)null);
                });

            modelBuilder.Entity("RestauranteAtual.Domain.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("NOME");

                    b.Property<decimal>("ValorUnitario")
                        .HasPrecision(7, 2)
                        .HasColumnType("decimal")
                        .HasColumnName("VALORUNITARIO");

                    b.HasKey("Id");

                    b.ToTable("PRODUTO", (string)null);
                });

            modelBuilder.Entity("RestauranteAtual.Domain.Restaurante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("BAIRRO");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar")
                        .HasColumnName("CEP");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("CNPJ");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("CIDADE");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("ENDERECO");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("ESTADO");

                    b.Property<string>("HorarioFuncionamento")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar")
                        .HasColumnName("HORARIOFUNCIONAMENTO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("NOME");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("NUMERO");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("PAIS");

                    b.Property<string>("QuantidadeMaxima")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar")
                        .HasColumnName("QUANTIDADEMAXIMA");

                    b.Property<int>("QuantidadeMesa")
                        .HasColumnType("int")
                        .HasColumnName("QUANTIDADEMESA");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar")
                        .HasColumnName("TELEFONE");

                    b.HasKey("Id");

                    b.ToTable("RESTAURANTE", (string)null);
                });

            modelBuilder.Entity("RestauranteAtual.Domain.ItensPedido", b =>
                {
                    b.HasOne("RestauranteAtual.Domain.Garcom", "Garcom")
                        .WithOne("ItensPedido")
                        .HasForeignKey("RestauranteAtual.Domain.ItensPedido", "IdGarcom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestauranteAtual.Domain.Pedido", "Pedido")
                        .WithOne("ItensPedido")
                        .HasForeignKey("RestauranteAtual.Domain.ItensPedido", "IdPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestauranteAtual.Domain.Produto", "Produto")
                        .WithOne("ItensPedido")
                        .HasForeignKey("RestauranteAtual.Domain.ItensPedido", "IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Garcom");

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("RestauranteAtual.Domain.Mesa", b =>
                {
                    b.HasOne("RestauranteAtual.Domain.Restaurante", "Restaurante")
                        .WithOne("Mesa")
                        .HasForeignKey("RestauranteAtual.Domain.Mesa", "IdRestaurante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurante");
                });

            modelBuilder.Entity("RestauranteAtual.Domain.Pedido", b =>
                {
                    b.HasOne("RestauranteAtual.Domain.Cliente", "Cliente")
                        .WithOne("Pedido")
                        .HasForeignKey("RestauranteAtual.Domain.Pedido", "IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestauranteAtual.Domain.Mesa", "Mesa")
                        .WithOne("Pedido")
                        .HasForeignKey("RestauranteAtual.Domain.Pedido", "IdMesa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Mesa");
                });

            modelBuilder.Entity("RestauranteAtual.Domain.Cliente", b =>
                {
                    b.Navigation("Pedido")
                        .IsRequired();
                });

            modelBuilder.Entity("RestauranteAtual.Domain.Garcom", b =>
                {
                    b.Navigation("ItensPedido")
                        .IsRequired();
                });

            modelBuilder.Entity("RestauranteAtual.Domain.Mesa", b =>
                {
                    b.Navigation("Pedido")
                        .IsRequired();
                });

            modelBuilder.Entity("RestauranteAtual.Domain.Pedido", b =>
                {
                    b.Navigation("ItensPedido")
                        .IsRequired();
                });

            modelBuilder.Entity("RestauranteAtual.Domain.Produto", b =>
                {
                    b.Navigation("ItensPedido")
                        .IsRequired();
                });

            modelBuilder.Entity("RestauranteAtual.Domain.Restaurante", b =>
                {
                    b.Navigation("Mesa")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
