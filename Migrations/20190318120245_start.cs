using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreEnumToStringTest.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "my_entities",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    status = table.Column<string>(nullable: false),
                    due_at_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_my_entities", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "my_entities");
        }
    }
}
