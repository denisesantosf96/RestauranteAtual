using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestauranteAtual.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    RG = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ENDERECO = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    NUMERO = table.Column<int>(type: "int", nullable: false),
                    BAIRRO = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CIDADE = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ESTADO = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    PAIS = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    CEP = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false),
                    GENERO = table.Column<string>(type: "char", nullable: false),
                    DATANASCIMENTO = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GARCOM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    IDADE = table.Column<int>(type: "int", nullable: false),
                    DATAADMISSAO = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GARCOM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    VALORUNITARIO = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RESTAURANTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    TELEFONE = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    ENDERECO = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    NUMERO = table.Column<int>(type: "int", nullable: false),
                    BAIRRO = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CIDADE = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ESTADO = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    PAIS = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    CEP = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false),
                    HORARIOFUNCIONAMENTO = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    QUANTIDADEMAXIMA = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    QUANTIDADEMESA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RESTAURANTE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MESA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRestaurante = table.Column<int>(type: "int", nullable: false),
                    LOCALIZACAO = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NUMERODAMESA = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MESA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MESA_RESTAURANTE_IdRestaurante",
                        column: x => x.IdRestaurante,
                        principalTable: "RESTAURANTE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PEDIDO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMesa = table.Column<int>(type: "int", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false),
                    STATUS = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    QUANTIDADEDEITENS = table.Column<int>(type: "int", nullable: false),
                    FORMAPAGAMENTO = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    VALOR = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PEDIDO_CLIENTE_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "CLIENTE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PEDIDO_MESA_IdMesa",
                        column: x => x.IdMesa,
                        principalTable: "MESA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ITENSPEDIDO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPedido = table.Column<int>(type: "int", nullable: false),
                    IdGarcom = table.Column<int>(type: "int", nullable: false),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    QUANTIDADE = table.Column<int>(type: "int", nullable: false),
                    VALORITEM = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITENSPEDIDO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ITENSPEDIDO_GARCOM_IdGarcom",
                        column: x => x.IdGarcom,
                        principalTable: "GARCOM",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ITENSPEDIDO_PEDIDO_IdPedido",
                        column: x => x.IdPedido,
                        principalTable: "PEDIDO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ITENSPEDIDO_PRODUTO_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "PRODUTO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ITENSPEDIDO_IdGarcom",
                table: "ITENSPEDIDO",
                column: "IdGarcom",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ITENSPEDIDO_IdPedido",
                table: "ITENSPEDIDO",
                column: "IdPedido",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ITENSPEDIDO_IdProduto",
                table: "ITENSPEDIDO",
                column: "IdProduto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MESA_IdRestaurante",
                table: "MESA",
                column: "IdRestaurante",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDO_IdCliente",
                table: "PEDIDO",
                column: "IdCliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDO_IdMesa",
                table: "PEDIDO",
                column: "IdMesa",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ITENSPEDIDO");

            migrationBuilder.DropTable(
                name: "GARCOM");

            migrationBuilder.DropTable(
                name: "PEDIDO");

            migrationBuilder.DropTable(
                name: "PRODUTO");

            migrationBuilder.DropTable(
                name: "CLIENTE");

            migrationBuilder.DropTable(
                name: "MESA");

            migrationBuilder.DropTable(
                name: "RESTAURANTE");
        }
    }
}
