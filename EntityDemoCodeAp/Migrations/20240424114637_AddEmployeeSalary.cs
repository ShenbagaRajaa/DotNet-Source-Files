using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityDemoCodeAp.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeSalary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "EmployeeSalary",
                table: "EmployeeShenbabs",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeSalary",
                table: "EmployeeShenbabs");
        }
    }
}
