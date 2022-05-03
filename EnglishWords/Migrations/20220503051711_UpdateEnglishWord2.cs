using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnglishWords.Migrations
{
    public partial class UpdateEnglishWord2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudyCount",
                table: "EnglishWords",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudyCount",
                table: "EnglishWords");
        }
    }
}
