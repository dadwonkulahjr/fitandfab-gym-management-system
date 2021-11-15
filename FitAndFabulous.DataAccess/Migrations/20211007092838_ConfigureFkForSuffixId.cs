using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAndFabulous.DataAccess.Migrations
{
    public partial class ConfigureFkForSuffixId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Persons_SuffixId",
                table: "Persons",
                column: "SuffixId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Suffixes_SuffixId",
                table: "Persons",
                column: "SuffixId",
                principalTable: "Suffixes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Suffixes_SuffixId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_SuffixId",
                table: "Persons");
        }
    }
}
