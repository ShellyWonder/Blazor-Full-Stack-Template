﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrandedWebAppWithAuth.Migrations
{
    /// <inheritdoc />
    public partial class _004AddTypeToImageUpload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Images",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Images");
        }
    }
}
