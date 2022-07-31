using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleApi.DBContext.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_location",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_Cordenadas = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_location_tbl_cordenada_Id_Cordenadas",
                        column: x => x.Id_Cordenadas,
                        principalTable: "tbl_cordenada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_northeast",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_Cordenadas = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_northeast", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_northeast_tbl_cordenada_Id_Cordenadas",
                        column: x => x.Id_Cordenadas,
                        principalTable: "tbl_cordenada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_southwest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_Cordenadas = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_southwest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_southwest_tbl_cordenada_Id_Cordenadas",
                        column: x => x.Id_Cordenadas,
                        principalTable: "tbl_cordenada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_bounds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_northeast = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_southwest = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_bounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_bounds_tbl_northeast",
                        column: x => x.Id_northeast,
                        principalTable: "tbl_northeast",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_bounds_tbl_southwest",
                        column: x => x.Id_southwest,
                        principalTable: "tbl_southwest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_bounds_Id_northeast",
                table: "tbl_bounds",
                column: "Id_northeast",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_bounds_Id_southwest",
                table: "tbl_bounds",
                column: "Id_southwest",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_location_Id_Cordenadas",
                table: "tbl_location",
                column: "Id_Cordenadas",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_northeast_Id_Cordenadas",
                table: "tbl_northeast",
                column: "Id_Cordenadas",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_southwest_Id_Cordenadas",
                table: "tbl_southwest",
                column: "Id_Cordenadas",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_bounds");

            migrationBuilder.DropTable(
                name: "tbl_location");

            migrationBuilder.DropTable(
                name: "tbl_northeast");

            migrationBuilder.DropTable(
                name: "tbl_southwest");
        }
    }
}
