using Microsoft.EntityFrameworkCore.Migrations;

namespace aec_webapi_ef.Migrations
{
    public partial class JobsADD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "profissoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profissoes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "candidatos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpf = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    nascimento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    profissaoId = table.Column<int>(type: "int", nullable: false),
                    logradouro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    complemento = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    numero = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    bairro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    cep = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    estado = table.Column<string>(type: "nchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidatos", x => x.id);
                    table.ForeignKey(
                        name: "FK_candidatos_profissoes_profissaoId",
                        column: x => x.profissaoId,
                        principalTable: "profissoes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_candidatos_cpf",
                table: "candidatos",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_candidatos_profissaoId",
                table: "candidatos",
                column: "profissaoId");

            migrationBuilder.CreateIndex(
                name: "IX_profissoes_nome",
                table: "profissoes",
                column: "nome",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "candidatos");

            migrationBuilder.DropTable(
                name: "profissoes");
        }
    }
}
