using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAppAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "post",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    date_posted = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_post", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "post");
        }
    }
}
