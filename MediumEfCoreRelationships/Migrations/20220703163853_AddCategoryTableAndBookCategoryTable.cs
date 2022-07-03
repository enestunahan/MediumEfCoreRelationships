using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediumEfCoreRelationships.Migrations
{
    public partial class AddCategoryTableAndBookCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<short>(type: "smallint", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookCategories_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { (short)1, null, "Roman" },
                    { (short)2, null, "Edebiyat" },
                    { (short)3, null, "Fantastik" },
                    { (short)4, null, "Akademik" },
                    { (short)5, null, "Yazılım" }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "Id", "BookId", "CategoryId", "CreatedDate", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 1, (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 2, 1, (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 3, 2, (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 4, 2, (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 5, 3, (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 6, 3, (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 7, 4, (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 8, 4, (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 9, 5, (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 10, 5, (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCategories_BookId",
                table: "BookCategories",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCategories_CategoryId",
                table: "BookCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
