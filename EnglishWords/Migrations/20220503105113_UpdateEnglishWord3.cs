using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnglishWords.Migrations
{
    public partial class UpdateEnglishWord3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Answered",
                table: "EnglishWords",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answered",
                table: "EnglishWords");
        }
    }
}
