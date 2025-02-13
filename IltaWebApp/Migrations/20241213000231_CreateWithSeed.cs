using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IltaWebApp.Migrations
{
    /// <inheritdoc />
    public partial class CreateWithSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Image_url = table.Column<string>(type: "TEXT", nullable: false),
                    text = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_account",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    user_name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    password = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    role = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_account", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "user_account",
                columns: new[] { "id", "password", "role", "user_name" },
                values: new object[] { 1, "password", "Administrator", "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "user_account");
        }
    }
}
