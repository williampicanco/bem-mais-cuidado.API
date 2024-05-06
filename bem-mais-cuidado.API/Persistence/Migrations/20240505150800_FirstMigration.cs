using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bem_mais_cuidado.API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAgendamentoBemMaisCuidado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAgendaBemMaisCuidado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Horario_Inicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario_Final = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdColaboradorBemMaisCuidado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponsavelCriacao = table.Column<int>(type: "int", nullable: false),
                    ResponsavelAtualizacao = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAgendaBemMaisCuidao = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdColaborado = table.Column<int>(type: "int", nullable: false),
                    IdLocalAtividadeBemMaisCuidado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdConfiguracaoAgendaBemMaisCuidado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    DiaDaSemana = table.Column<int>(type: "int", nullable: false),
                    HoraInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraAlmocoInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraAlmocoFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuracaoSessao = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamentos");

            migrationBuilder.DropTable(
                name: "Agendas");
        }
    }
}
