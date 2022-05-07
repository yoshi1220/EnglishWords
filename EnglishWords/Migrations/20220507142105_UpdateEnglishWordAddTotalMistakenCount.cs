using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnglishWords.Migrations
{
    public partial class UpdateEnglishWordAddTotalMistakenCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalMistakenCount",
                table: "EnglishWords",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalMistakenCount",
                table: "EnglishWords");
        }
    }
}
