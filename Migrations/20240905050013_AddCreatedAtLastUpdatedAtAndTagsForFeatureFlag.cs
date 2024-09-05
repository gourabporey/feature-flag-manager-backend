using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace feature_flag_manager_backend.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedAtLastUpdatedAtAndTagsForFeatureFlag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "FeatureFlags");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "FeatureFlags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                table: "FeatureFlags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "FeatureFlags",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "FeatureFlags");

            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                table: "FeatureFlags");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "FeatureFlags");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "FeatureFlags",
                type: "datetime2",
                nullable: true);
        }
    }
}
