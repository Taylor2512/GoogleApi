using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleApi.DBContext.Migrations
{
    public partial class _365 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "location_type",
                columns: table => new
                {
                    Id_location_type = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location_type", x => x.Id_location_type);
                });

            migrationBuilder.CreateTable(
                name: "tbl_geometry",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_bounds = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_viewport = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_location = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_location_type = table.Column<byte>(type: "tinyint", nullable: false),
                    viewportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_geometry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_geometry_location_type_Id_location_type",
                        column: x => x.Id_location_type,
                        principalTable: "location_type",
                        principalColumn: "Id_location_type",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_geometry_tbl_bounds_Id_bounds",
                        column: x => x.Id_bounds,
                        principalTable: "tbl_bounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_geometry_tbl_bounds_viewportId",
                        column: x => x.viewportId,
                        principalTable: "tbl_bounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_geometry_tbl_cordenada_Id_location",
                        column: x => x.Id_location,
                        principalTable: "tbl_cordenada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_geometry_Id_bounds",
                table: "tbl_geometry",
                column: "Id_bounds",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_geometry_Id_location",
                table: "tbl_geometry",
                column: "Id_location",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_geometry_Id_location_type",
                table: "tbl_geometry",
                column: "Id_location_type");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_geometry_viewportId",
                table: "tbl_geometry",
                column: "viewportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_geometry");

            migrationBuilder.DropTable(
                name: "location_type");
        }
    }
}
