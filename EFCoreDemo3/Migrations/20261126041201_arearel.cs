using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDemo3.Migrations
{
    public partial class arearel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AreaID",
                table: "TblDept",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    AreaID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.AreaID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblDept_AreaID",
                table: "TblDept",
                column: "AreaID");

            migrationBuilder.AddForeignKey(
                name: "FK_TblDept_Areas_AreaID",
                table: "TblDept",
                column: "AreaID",
                principalTable: "Areas",
                principalColumn: "AreaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblDept_Areas_AreaID",
                table: "TblDept");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropIndex(
                name: "IX_TblDept_AreaID",
                table: "TblDept");

            migrationBuilder.DropColumn(
                name: "AreaID",
                table: "TblDept");
        }
    }
}
