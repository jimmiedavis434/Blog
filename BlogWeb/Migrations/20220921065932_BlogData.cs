using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWeb.Migrations
{
    public partial class BlogData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BlogPrelude = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BlogDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogKeyword1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogKeyword2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogKeyword3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogArticle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogImageUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogImageUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogImageUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.BlogId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogs");
        }
    }
}
