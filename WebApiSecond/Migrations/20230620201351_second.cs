using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiSecond.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Voda",
                table: "Voda");

            migrationBuilder.AlterColumn<string>(
                name: "Count",
                table: "Voda",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VodaTypeModelId",
                table: "Voda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VodaTypeModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VodaType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VodaTypeModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Voda_VodaTypeModelId",
                table: "Voda",
                column: "VodaTypeModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voda_VodaTypeModel_VodaTypeModelId",
                table: "Voda",
                column: "VodaTypeModelId",
                principalTable: "VodaTypeModel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voda_VodaTypeModel_VodaTypeModelId",
                table: "Voda");

            migrationBuilder.DropTable(
                name: "VodaTypeModel");

            migrationBuilder.DropIndex(
                name: "IX_Voda_VodaTypeModelId",
                table: "Voda");

            migrationBuilder.DropColumn(
                name: "VodaTypeModelId",
                table: "Voda");

            migrationBuilder.AlterColumn<string>(
                name: "Count",
                table: "Voda",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Voda",
                table: "Voda",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
