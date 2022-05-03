using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnglishWords.Migrations
{
    public partial class UpdateEnglishWord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MistakenCount",
                table: "EnglishWords",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MistakenCount",
                table: "EnglishWords");
        }
    }
}
