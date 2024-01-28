using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelApi.Migrations
{
    /// <inheritdoc />
    public partial class messi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cargos",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargos", x => x.CargoId);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    Nacionalidade = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "consumos",
                columns: table => new
                {
                    ConsumoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    EntregueQuarto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consumos", x => x.ConsumoId);
                });

            migrationBuilder.CreateTable(
                name: "servicos",
                columns: table => new
                {
                    ServicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Preco = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicos", x => x.ServicoId);
                });

            migrationBuilder.CreateTable(
                name: "statusQuarto",
                columns: table => new
                {
                    StatusQuartoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statusQuarto", x => x.StatusQuartoId);
                });

            migrationBuilder.CreateTable(
                name: "tiposPagamentos",
                columns: table => new
                {
                    TipoPagamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiposPagamentos", x => x.TipoPagamentoId);
                });

            migrationBuilder.CreateTable(
                name: "tiposQuarto",
                columns: table => new
                {
                    TipoQuartoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiposQuarto", x => x.TipoQuartoId);
                });

            migrationBuilder.CreateTable(
                name: "funcionarios",
                columns: table => new
                {
                    CodFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CargoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionarios", x => x.CodFuncionario);
                    table.ForeignKey(
                        name: "FK_funcionarios_cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "cargos",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "enderecoCliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId1 = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Rua = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderecoCliente", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_enderecoCliente_clientes_ClienteId1",
                        column: x => x.ClienteId1,
                        principalTable: "clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "quartos",
                columns: table => new
                {
                    QuartoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumQuarto = table.Column<int>(type: "int", nullable: false),
                    TipoQuartoId = table.Column<int>(type: "int", nullable: false),
                    Adaptado = table.Column<int>(type: "int", nullable: false),
                    statusQuartoId = table.Column<int>(type: "int", nullable: false),
                    ValorQuarto = table.Column<double>(type: "float", nullable: false),
                    CapacidadeMaxima = table.Column<int>(type: "int", nullable: false),
                    CapacidadeOpcional = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quartos", x => x.QuartoId);
                    table.ForeignKey(
                        name: "FK_quartos_statusQuarto_statusQuartoId",
                        column: x => x.statusQuartoId,
                        principalTable: "statusQuarto",
                        principalColumn: "StatusQuartoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_quartos_tiposQuarto_TipoQuartoId",
                        column: x => x.TipoQuartoId,
                        principalTable: "tiposQuarto",
                        principalColumn: "TipoQuartoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservas",
                columns: table => new
                {
                    ReservaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtCancelamento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    ValorDiaria = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservas", x => x.ReservaId);
                    table.ForeignKey(
                        name: "FK_reservas_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservas_funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "funcionarios",
                        principalColumn: "CodFuncionario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "filiais",
                columns: table => new
                {
                    FilialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFilial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuartoId = table.Column<int>(type: "int", nullable: false),
                    CidadeFilial = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    RuaFilial = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NumeroFilial = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    QuantEstrelas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filiais", x => x.FilialId);
                    table.ForeignKey(
                        name: "FK_filiais_quartos_QuartoId",
                        column: x => x.QuartoId,
                        principalTable: "quartos",
                        principalColumn: "QuartoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "notasFicais",
                columns: table => new
                {
                    NotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservaId = table.Column<int>(type: "int", nullable: false),
                    TipoPagamentoId = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notasFicais", x => x.NotaId);
                    table.ForeignKey(
                        name: "FK_notasFicais_reservas_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "reservas",
                        principalColumn: "ReservaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_notasFicais_tiposPagamentos_TipoPagamentoId",
                        column: x => x.TipoPagamentoId,
                        principalTable: "tiposPagamentos",
                        principalColumn: "TipoPagamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "quartosReservas",
                columns: table => new
                {
                    ReservaId = table.Column<int>(type: "int", nullable: false),
                    QuartoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quartosReservas", x => new { x.ReservaId, x.QuartoId });
                    table.ForeignKey(
                        name: "FK_quartosReservas_quartos_QuartoId",
                        column: x => x.QuartoId,
                        principalTable: "quartos",
                        principalColumn: "QuartoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_quartosReservas_reservas_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "reservas",
                        principalColumn: "ReservaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservaConsumos",
                columns: table => new
                {
                    ReservaId = table.Column<int>(type: "int", nullable: false),
                    ConsumoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservaConsumos", x => new { x.ReservaId, x.ConsumoId });
                    table.ForeignKey(
                        name: "FK_reservaConsumos_consumos_ConsumoId",
                        column: x => x.ConsumoId,
                        principalTable: "consumos",
                        principalColumn: "ConsumoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservaConsumos_reservas_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "reservas",
                        principalColumn: "ReservaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservaServicos",
                columns: table => new
                {
                    ReservaId = table.Column<int>(type: "int", nullable: false),
                    ServicoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservaServicos", x => new { x.ReservaId, x.ServicoId });
                    table.ForeignKey(
                        name: "FK_reservaServicos_reservas_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "reservas",
                        principalColumn: "ReservaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservaServicos_servicos_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "servicos",
                        principalColumn: "ServicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_enderecoCliente_ClienteId1",
                table: "enderecoCliente",
                column: "ClienteId1");

            migrationBuilder.CreateIndex(
                name: "IX_filiais_QuartoId",
                table: "filiais",
                column: "QuartoId");

            migrationBuilder.CreateIndex(
                name: "IX_funcionarios_CargoId",
                table: "funcionarios",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_notasFicais_ReservaId",
                table: "notasFicais",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_notasFicais_TipoPagamentoId",
                table: "notasFicais",
                column: "TipoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_quartos_statusQuartoId",
                table: "quartos",
                column: "statusQuartoId");

            migrationBuilder.CreateIndex(
                name: "IX_quartos_TipoQuartoId",
                table: "quartos",
                column: "TipoQuartoId");

            migrationBuilder.CreateIndex(
                name: "IX_quartosReservas_QuartoId",
                table: "quartosReservas",
                column: "QuartoId");

            migrationBuilder.CreateIndex(
                name: "IX_reservaConsumos_ConsumoId",
                table: "reservaConsumos",
                column: "ConsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_reservas_ClienteId",
                table: "reservas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_reservas_FuncionarioId",
                table: "reservas",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_reservaServicos_ServicoId",
                table: "reservaServicos",
                column: "ServicoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "enderecoCliente");

            migrationBuilder.DropTable(
                name: "filiais");

            migrationBuilder.DropTable(
                name: "notasFicais");

            migrationBuilder.DropTable(
                name: "quartosReservas");

            migrationBuilder.DropTable(
                name: "reservaConsumos");

            migrationBuilder.DropTable(
                name: "reservaServicos");

            migrationBuilder.DropTable(
                name: "tiposPagamentos");

            migrationBuilder.DropTable(
                name: "quartos");

            migrationBuilder.DropTable(
                name: "consumos");

            migrationBuilder.DropTable(
                name: "reservas");

            migrationBuilder.DropTable(
                name: "servicos");

            migrationBuilder.DropTable(
                name: "statusQuarto");

            migrationBuilder.DropTable(
                name: "tiposQuarto");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "funcionarios");

            migrationBuilder.DropTable(
                name: "cargos");
        }
    }
}
