using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prodotti",
                columns: table => new
                {
                    ProdottoID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                    DescrizioneProdotto = table.Column<string>(type: "TEXT", nullable: true),
                    PrezzoPublico = table.Column<decimal>(type: "TEXT", nullable: false),
                    IVA = table.Column<ushort>(type: "INTEGER", nullable: false),
                    PrezzoPublicoNoIva = table.Column<decimal>(type: "TEXT", nullable: false),
                    PrezzoNetto = table.Column<decimal>(type: "TEXT", nullable: false),
                    Sconto = table.Column<decimal>(type: "TEXT", nullable: false),
                    Listino = table.Column<ushort>(type: "INTEGER", nullable: false),
                    ScontoMax = table.Column<decimal>(type: "TEXT", nullable: false),
                    PezziMin = table.Column<ushort>(type: "INTEGER", nullable: false),
                    PezziMax = table.Column<ushort>(type: "INTEGER", nullable: false),
                    CollegamentoImmagine = table.Column<string>(type: "TEXT", nullable: true),
                    Attivo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prodotti", x => x.ProdottoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prodotti");
        }
    }
}
