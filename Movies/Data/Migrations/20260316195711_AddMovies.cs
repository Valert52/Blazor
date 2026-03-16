using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abc.Soft.Movies.Migrations
{
    /// <inheritdoc />
    public partial class AddMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movies",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Movies",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidFrom",
                table: "Movies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidTo",
                table: "Movies",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ValidFrom",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ValidTo",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movies",
                newName: "Title");

            migrationBuilder.AddColumn<DateOnly>(
                name: "ReleaseDate",
                table: "Movies",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }
    }
}
