﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_Point.Migrations
{
    /// <inheritdoc />
    public partial class add_views_counter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "Movies");
        }
    }
}
