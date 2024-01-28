﻿// <auto-generated />
using System;
using HotelApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelApi.Migrations
{
    [DbContext(typeof(HotelDBContext))]
    [Migration("20240128194657_messi")]
    partial class messi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelApi.Model.Cargos", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CargoId"));

                    b.Property<string>("Descricao")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CargoId");

                    b.ToTable("cargos");
                });

            modelBuilder.Entity("HotelApi.Model.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("Email")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Nacionalidade")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("NomeCliente")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("ClienteId");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("HotelApi.Model.Consumos", b =>
                {
                    b.Property<int>("ConsumoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsumoId"));

                    b.Property<string>("Descricao")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("EntregueQuarto")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("ConsumoId");

                    b.ToTable("consumos");
                });

            modelBuilder.Entity("HotelApi.Model.EnderecoCliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("Cidade")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ClienteId1")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Rua")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ClienteId");

                    b.HasIndex("ClienteId1");

                    b.ToTable("enderecoCliente");
                });

            modelBuilder.Entity("HotelApi.Model.Filiais", b =>
                {
                    b.Property<int>("FilialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilialId"));

                    b.Property<string>("CidadeFilial")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NomeFilial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroFilial")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("QuantEstrelas")
                        .HasColumnType("int");

                    b.Property<int>("QuartoId")
                        .HasColumnType("int");

                    b.Property<string>("RuaFilial")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("FilialId");

                    b.HasIndex("QuartoId");

                    b.ToTable("filiais");
                });

            modelBuilder.Entity("HotelApi.Model.Funcionarios", b =>
                {
                    b.Property<int>("CodFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodFuncionario"));

                    b.Property<int>("CargoId")
                        .HasColumnType("int");

                    b.Property<string>("NomeFuncionario")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CodFuncionario");

                    b.HasIndex("CargoId");

                    b.ToTable("funcionarios");
                });

            modelBuilder.Entity("HotelApi.Model.NotasFicais", b =>
                {
                    b.Property<int>("NotaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotaId"));

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.Property<int>("TipoPagamentoId")
                        .HasColumnType("int");

                    b.HasKey("NotaId");

                    b.HasIndex("ReservaId");

                    b.HasIndex("TipoPagamentoId");

                    b.ToTable("notasFicais");
                });

            modelBuilder.Entity("HotelApi.Model.Quartos", b =>
                {
                    b.Property<int>("QuartoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuartoId"));

                    b.Property<int>("Adaptado")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadeMaxima")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadeOpcional")
                        .HasColumnType("int");

                    b.Property<int>("NumQuarto")
                        .HasColumnType("int");

                    b.Property<int>("TipoQuartoId")
                        .HasColumnType("int");

                    b.Property<double>("ValorQuarto")
                        .HasColumnType("float");

                    b.Property<int>("statusQuartoId")
                        .HasColumnType("int");

                    b.HasKey("QuartoId");

                    b.HasIndex("TipoQuartoId");

                    b.HasIndex("statusQuartoId");

                    b.ToTable("quartos");
                });

            modelBuilder.Entity("HotelApi.Model.QuartosReservas", b =>
                {
                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.Property<int>("QuartoId")
                        .HasColumnType("int");

                    b.HasKey("ReservaId", "QuartoId");

                    b.HasIndex("QuartoId");

                    b.ToTable("quartosReservas");
                });

            modelBuilder.Entity("HotelApi.Model.ReservaConsumos", b =>
                {
                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.Property<int>("ConsumoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("ReservaId", "ConsumoId");

                    b.HasIndex("ConsumoId");

                    b.ToTable("reservaConsumos");
                });

            modelBuilder.Entity("HotelApi.Model.ReservaServicos", b =>
                {
                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("ReservaId", "ServicoId");

                    b.HasIndex("ServicoId");

                    b.ToTable("reservaServicos");
                });

            modelBuilder.Entity("HotelApi.Model.Reservas", b =>
                {
                    b.Property<int>("ReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservaId"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DtCancelamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DtEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DtSaida")
                        .HasColumnType("datetime2");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<double>("ValorDiaria")
                        .HasColumnType("float");

                    b.HasKey("ReservaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("reservas");
                });

            modelBuilder.Entity("HotelApi.Model.Servicos", b =>
                {
                    b.Property<int>("ServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServicoId"));

                    b.Property<string>("Descricao")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("ServicoId");

                    b.ToTable("servicos");
                });

            modelBuilder.Entity("HotelApi.Model.StatusQuarto", b =>
                {
                    b.Property<int>("StatusQuartoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusQuartoId"));

                    b.Property<string>("Descricao")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("StatusQuartoId");

                    b.ToTable("statusQuarto");
                });

            modelBuilder.Entity("HotelApi.Model.TiposPagamentos", b =>
                {
                    b.Property<int>("TipoPagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoPagamentoId"));

                    b.Property<string>("Descricao")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("TipoPagamentoId");

                    b.ToTable("tiposPagamentos");
                });

            modelBuilder.Entity("HotelApi.Model.TiposQuarto", b =>
                {
                    b.Property<int>("TipoQuartoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoQuartoId"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoQuartoId");

                    b.ToTable("tiposQuarto");
                });

            modelBuilder.Entity("HotelApi.Model.EnderecoCliente", b =>
                {
                    b.HasOne("HotelApi.Model.Clientes", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("HotelApi.Model.Filiais", b =>
                {
                    b.HasOne("HotelApi.Model.Quartos", "Quarto")
                        .WithMany()
                        .HasForeignKey("QuartoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quarto");
                });

            modelBuilder.Entity("HotelApi.Model.Funcionarios", b =>
                {
                    b.HasOne("HotelApi.Model.Cargos", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("HotelApi.Model.NotasFicais", b =>
                {
                    b.HasOne("HotelApi.Model.Reservas", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelApi.Model.TiposPagamentos", "TipoPagamento")
                        .WithMany()
                        .HasForeignKey("TipoPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");

                    b.Navigation("TipoPagamento");
                });

            modelBuilder.Entity("HotelApi.Model.Quartos", b =>
                {
                    b.HasOne("HotelApi.Model.TiposQuarto", "TipoQuarto")
                        .WithMany()
                        .HasForeignKey("TipoQuartoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelApi.Model.StatusQuarto", "statusQuarto")
                        .WithMany()
                        .HasForeignKey("statusQuartoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoQuarto");

                    b.Navigation("statusQuarto");
                });

            modelBuilder.Entity("HotelApi.Model.QuartosReservas", b =>
                {
                    b.HasOne("HotelApi.Model.Quartos", "Quarto")
                        .WithMany()
                        .HasForeignKey("QuartoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelApi.Model.Reservas", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quarto");

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("HotelApi.Model.ReservaConsumos", b =>
                {
                    b.HasOne("HotelApi.Model.Consumos", "Consumo")
                        .WithMany()
                        .HasForeignKey("ConsumoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelApi.Model.Reservas", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consumo");

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("HotelApi.Model.ReservaServicos", b =>
                {
                    b.HasOne("HotelApi.Model.Reservas", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelApi.Model.Servicos", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("HotelApi.Model.Reservas", b =>
                {
                    b.HasOne("HotelApi.Model.Clientes", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelApi.Model.Funcionarios", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}
