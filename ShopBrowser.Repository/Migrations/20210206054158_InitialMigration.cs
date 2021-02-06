using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopBrowser.Repository.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CloseTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopEntities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ShopEntities",
                columns: new[] { "Id", "CloseTime", "Description", "Name", "OpenTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), "eMobile Shop", "eMobile", new DateTime(2021, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2021, 2, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), "Кандаловъ Shop", "Кандаловъ", new DateTime(2021, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2021, 2, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), "MEX Shop", "MEX", new DateTime(2021, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2021, 2, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), "патриот Shop", "патриот", new DateTime(2021, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2021, 2, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), "Hot-Line Shop", "Hot-Line", new DateTime(2021, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopEntities");
        }
    }
}
