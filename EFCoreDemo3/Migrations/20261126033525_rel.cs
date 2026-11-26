using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDemo3.Migrations
{
    public partial class rel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DeptDID",
                table: "TblEmp",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblEmp_DeptDID",
                table: "TblEmp",
                column: "DeptDID");

            migrationBuilder.AddForeignKey(
                name: "FK_TblEmp_TblDept_DeptDID",
                table: "TblEmp",
                column: "DeptDID",
                principalTable: "TblDept",
                principalColumn: "DID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblEmp_TblDept_DeptDID",
                table: "TblEmp");

            migrationBuilder.DropIndex(
                name: "IX_TblEmp_DeptDID",
                table: "TblEmp");

            migrationBuilder.DropColumn(
                name: "DeptDID",
                table: "TblEmp");
        }
    }
}
