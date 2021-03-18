using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prodject_ПРІС.Migrations
{
    public partial class test_sql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassRooms",
                columns: table => new
                {
                    idCr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameCr = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DateCr = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRooms", x => x.idCr);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    idst = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameSt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    birthadateSt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateSt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCr = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.idst);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassRooms");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
