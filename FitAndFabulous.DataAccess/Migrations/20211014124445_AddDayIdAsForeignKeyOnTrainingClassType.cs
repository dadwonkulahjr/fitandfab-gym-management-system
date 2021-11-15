using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAndFabulous.DataAccess.Migrations
{
    public partial class AddDayIdAsForeignKeyOnTrainingClassType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DayId",
                table: "TrainingClasses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingClasses_DayId",
                table: "TrainingClasses",
                column: "DayId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingClasses_Days_DayId",
                table: "TrainingClasses",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingClasses_Days_DayId",
                table: "TrainingClasses");

            migrationBuilder.DropIndex(
                name: "IX_TrainingClasses_DayId",
                table: "TrainingClasses");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "TrainingClasses");
        }
    }
}
