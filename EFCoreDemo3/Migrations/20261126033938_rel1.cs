using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDemo3.Migrations
{
    public partial class rel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DID",
                table: "TblEmp",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DID",
                table: "TblEmp");
        }
    }
}
