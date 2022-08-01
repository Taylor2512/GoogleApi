using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleApi.DBContext.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "address_Components",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    long_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    short_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_Components", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GoogleAdress_types",
                columns: table => new
                {
                    Id_GoogleAdress_types = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoogleAdress_types", x => x.Id_GoogleAdress_types);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "location_type",
                columns: table => new
                {
                    Id_location_type = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location_type", x => x.Id_location_type);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "plus_code",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    compound_code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    global_code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plus_code", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_cordenada",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    latitud = table.Column<double>(type: "double", nullable: false),
                    Longitud = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_cordenada", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_address_components_and_GoogleAdressType",
                columns: table => new
                {
                    Id_address_components = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Id_GoogleAdress_types = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_address_components_and_GoogleAdressType", x => new { x.Id_GoogleAdress_types, x.Id_address_components });
                    table.ForeignKey(
                        name: "FK_tbl_address_components_and_GoogleAdressType_address_Componen~",
                        column: x => x.Id_address_components,
                        principalTable: "address_Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_address_components_and_GoogleAdressType_GoogleAdress_typ~",
                        column: x => x.Id_GoogleAdress_types,
                        principalTable: "GoogleAdress_types",
                        principalColumn: "Id_GoogleAdress_types",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_GobalAdress",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Id_plus_code = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_GobalAdress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_GobalAdress_plus_code_Id_plus_code",
                        column: x => x.Id_plus_code,
                        principalTable: "plus_code",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_bounds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Id_northeast = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Id_southwest = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_bounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_bounds_tbl_cordenada",
                        column: x => x.Id_northeast,
                        principalTable: "tbl_cordenada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_bounds_tbl_southwest2",
                        column: x => x.Id_southwest,
                        principalTable: "tbl_cordenada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_geometry",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Id_bounds = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Id_viewport = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Id_location = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Id_location_type = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_tbl_geometry_tbl_bounds_Id_viewport",
                        column: x => x.Id_viewport,
                        principalTable: "tbl_bounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_geometry_tbl_cordenada_Id_location",
                        column: x => x.Id_location,
                        principalTable: "tbl_cordenada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_google_adress",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Id_geometry = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    formatted_address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    place_id = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_plus_code = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Id_GobalAdress = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_google_adress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_google_adress_plus_code_Id_plus_code",
                        column: x => x.Id_plus_code,
                        principalTable: "plus_code",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_google_adress_tbl_geometry_Id_geometry",
                        column: x => x.Id_geometry,
                        principalTable: "tbl_geometry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_GobalAdress_and_GoogleAdress",
                columns: table => new
                {
                    Id_GobalAdress = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Id_GoogleAdress = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_GobalAdress_and_GoogleAdress", x => new { x.Id_GoogleAdress, x.Id_GobalAdress });
                    table.ForeignKey(
                        name: "FK_tbl_GobalAdress_and_GoogleAdress_tbl_GobalAdress_Id_GobalAdr~",
                        column: x => x.Id_GobalAdress,
                        principalTable: "tbl_GobalAdress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_GobalAdress_and_GoogleAdress_tbl_google_adress_Id_Google~",
                        column: x => x.Id_GoogleAdress,
                        principalTable: "tbl_google_adress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_google_adress_tiene_types",
                columns: table => new
                {
                    Id_GoogleAdress = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Id_GoogleAdress_types = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_google_adress_tiene_types", x => new { x.Id_GoogleAdress, x.Id_GoogleAdress_types });
                    table.ForeignKey(
                        name: "FK_tbl_google_adress_tiene_types_GoogleAdress_types_Id_GoogleAd~",
                        column: x => x.Id_GoogleAdress_types,
                        principalTable: "GoogleAdress_types",
                        principalColumn: "Id_GoogleAdress_types",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_google_adress_tiene_types_tbl_google_adress_Id_GoogleAdr~",
                        column: x => x.Id_GoogleAdress,
                        principalTable: "tbl_google_adress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbl_GoogleAdress_and_address_components",
                columns: table => new
                {
                    Id_address_components = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Id_GoogleAdress = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_GoogleAdress_and_address_components", x => new { x.Id_GoogleAdress, x.Id_address_components });
                    table.ForeignKey(
                        name: "FK_tbl_GoogleAdress_and_address_components_address_Components_I~",
                        column: x => x.Id_address_components,
                        principalTable: "address_Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_GoogleAdress_and_address_components_tbl_google_adress_Id~",
                        column: x => x.Id_GoogleAdress,
                        principalTable: "tbl_google_adress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_address_components_and_GoogleAdressType_Id_address_compo~",
                table: "tbl_address_components_and_GoogleAdressType",
                column: "Id_address_components");

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
                name: "IX_tbl_geometry_Id_viewport",
                table: "tbl_geometry",
                column: "Id_viewport",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_GobalAdress_Id_plus_code",
                table: "tbl_GobalAdress",
                column: "Id_plus_code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_GobalAdress_and_GoogleAdress_Id_GobalAdress",
                table: "tbl_GobalAdress_and_GoogleAdress",
                column: "Id_GobalAdress");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_google_adress_Id_geometry",
                table: "tbl_google_adress",
                column: "Id_geometry",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_google_adress_Id_plus_code",
                table: "tbl_google_adress",
                column: "Id_plus_code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_google_adress_tiene_types_Id_GoogleAdress_types",
                table: "tbl_google_adress_tiene_types",
                column: "Id_GoogleAdress_types");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_GoogleAdress_and_address_components_Id_address_components",
                table: "tbl_GoogleAdress_and_address_components",
                column: "Id_address_components");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_address_components_and_GoogleAdressType");

            migrationBuilder.DropTable(
                name: "tbl_GobalAdress_and_GoogleAdress");

            migrationBuilder.DropTable(
                name: "tbl_google_adress_tiene_types");

            migrationBuilder.DropTable(
                name: "tbl_GoogleAdress_and_address_components");

            migrationBuilder.DropTable(
                name: "tbl_GobalAdress");

            migrationBuilder.DropTable(
                name: "GoogleAdress_types");

            migrationBuilder.DropTable(
                name: "address_Components");

            migrationBuilder.DropTable(
                name: "tbl_google_adress");

            migrationBuilder.DropTable(
                name: "plus_code");

            migrationBuilder.DropTable(
                name: "tbl_geometry");

            migrationBuilder.DropTable(
                name: "location_type");

            migrationBuilder.DropTable(
                name: "tbl_bounds");

            migrationBuilder.DropTable(
                name: "tbl_cordenada");
        }
    }
}
