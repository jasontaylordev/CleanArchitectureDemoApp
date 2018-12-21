using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vertical.Persistance.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblDepartment",
                columns: table => new
                {
                    DeptId = table.Column<int>(nullable: false),
                    DeptName = table.Column<string>(unicode: false, maxLength: 600, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDepartment", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "tblEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 800, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(unicode: false, nullable: true),
                    Contact = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    Salary = table.Column<double>(nullable: false),
                    Email = table.Column<string>(unicode: false, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IsActive = table.Column<bool>(nullable: false),
                    DeptId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblEmployee_tblDepartment_DeptId",
                        column: x => x.DeptId,
                        principalTable: "tblDepartment",
                        principalColumn: "DeptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployee_DeptId",
                table: "tblEmployee",
                column: "DeptId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEmployee");

            migrationBuilder.DropTable(
                name: "tblDepartment");
        }
    }
}
