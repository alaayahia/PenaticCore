using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PenaticCore.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddShipmentRateEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShipmentDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OriginRegionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DestinationRegionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WeightValue = table.Column<double>(type: "float", nullable: false),
                    WeightUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LengthValue = table.Column<double>(type: "float", nullable: false),
                    WidthValue = table.Column<double>(type: "float", nullable: false),
                    HeightValue = table.Column<double>(type: "float", nullable: false),
                    DimensionUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipmentDetails_Regions_DestinationRegionId",
                        column: x => x.DestinationRegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShipmentDetails_Regions_OriginRegionId",
                        column: x => x.OriginRegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentRates",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShipmentServiceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShipmentDetailId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipmentRates_ShipmentDetails_ShipmentDetailId",
                        column: x => x.ShipmentDetailId,
                        principalTable: "ShipmentDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShipmentRates_ShipmentServices_ShipmentServiceId",
                        column: x => x.ShipmentServiceId,
                        principalTable: "ShipmentServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentDetails_DestinationRegionId",
                table: "ShipmentDetails",
                column: "DestinationRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentDetails_OriginRegionId",
                table: "ShipmentDetails",
                column: "OriginRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentRates_ShipmentDetailId",
                table: "ShipmentRates",
                column: "ShipmentDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentRates_ShipmentServiceId",
                table: "ShipmentRates",
                column: "ShipmentServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShipmentRates");

            migrationBuilder.DropTable(
                name: "ShipmentDetails");
        }
    }
}
