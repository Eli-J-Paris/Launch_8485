﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tourism.Migrations
{
    /// <inheritdoc />
    public partial class AddStateTimeZone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "time_zone",
                table: "states",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "time_zone",
                table: "states");
        }
    }
}
