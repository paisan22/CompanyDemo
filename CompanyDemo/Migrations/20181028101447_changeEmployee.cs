using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyDemo.Migrations
{
    public partial class changeEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "id",
                table: "employees");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "employees",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "employees",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "employees");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "employees",
                newName: "name");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "employees",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "id");
        }
    }
}
