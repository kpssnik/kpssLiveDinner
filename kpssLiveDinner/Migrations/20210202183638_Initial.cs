using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kpssLiveDinner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Heading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerReviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GalleryImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StuffItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StuffItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BlogItems",
                columns: new[] { "Id", "Author", "Date", "Heading", "Message" },
                values: new object[,]
                {
                    { 1, "Nikita Andreevich", new DateTime(2021, 2, 2, 18, 36, 37, 723, DateTimeKind.Utc).AddTicks(766), "So good for real...", "Nikita says that this web-application is so good yeah boy shit some text to fill kakakaka lorem ipsum ge ka" },
                    { 2, "Oleg Dubovoy", new DateTime(2021, 2, 2, 18, 36, 37, 724, DateTimeKind.Utc).AddTicks(8803), "So bad shit god damn...", "Oleg says thah this is full shit bitch fuck yeah ahahaha" }
                });

            migrationBuilder.InsertData(
                table: "CustomerReviews",
                columns: new[] { "Id", "Message", "Name", "Role" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam eu sem tempor, varius quam at, luctus dui. Mauris magna metus, dapibus nec turpis vel, semper malesuada ante. Idac bibendum scelerisque non non purus. Suspendisse varius nibh non aliquet.", "Paul Mitchel", "Web Designer" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam eu sem tempor, varius quam at, luctus dui. Mauris magna metus, dapibus nec turpis vel, semper malesuada ante. Idac bibendum scelerisque non non purus. Suspendisse varius nibh non aliquet.", "Redo Mufasa", "True rapper" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam eu sem tempor, varius quam at, luctus dui. Mauris magna metus, dapibus nec turpis vel, semper malesuada ante. Idac bibendum scelerisque non non purus. Suspendisse varius nibh non aliquet.", "John Wick", "Killer" }
                });

            migrationBuilder.InsertData(
                table: "GalleryImages",
                columns: new[] { "Id", "ImagePath" },
                values: new object[,]
                {
                    { 1, "gallery-img-01.jpg" },
                    { 2, "gallery-img-02.jpg" },
                    { 3, "gallery-img-03.jpg" },
                    { 4, "gallery-img-04.jpg" },
                    { 5, "gallery-img-05.jpg" }
                });

            migrationBuilder.InsertData(
                table: "StuffItems",
                columns: new[] { "Id", "ImagePath", "Name", "Role" },
                values: new object[,]
                {
                    { 1, "stuff-img-01.jpg", "Nikita Andreevich", "Master chief" },
                    { 2, "stuff-img-02.jpg", "Oleg Anatolievich", "Loh Killer" },
                    { 3, "stuff-img-03.jpg", "Valeriya Olegovna", "Killer sex doll" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogItems");

            migrationBuilder.DropTable(
                name: "CustomerReviews");

            migrationBuilder.DropTable(
                name: "GalleryImages");

            migrationBuilder.DropTable(
                name: "StuffItems");
        }
    }
}
