using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDarsl_1.Migrations
{
    public partial class ChangeModelName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hodims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    familya = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ism = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yosh = table.Column<int>(type: "int", nullable: false),
                    jins = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maosh = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hodims", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hodims");
        }
    }
}
