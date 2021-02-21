using Microsoft.EntityFrameworkCore.Migrations;

namespace Wipro.ProvaProgramacao.CSharpV3.Data.Migrations
{
    public partial class NovocampoemMoedas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mensagem",
                table: "Moedas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mensagem",
                table: "Moedas");
        }
    }
}
