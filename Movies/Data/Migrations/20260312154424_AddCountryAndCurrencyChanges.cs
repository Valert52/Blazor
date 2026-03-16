using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abc.Soft.Movies.Migrations
{
    /// <inheritdoc />
    public partial class AddCountryAndCurrencyChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "Currency",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Currency",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Currency",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Currency",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsIsoCurrency",
                table: "Currency",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MajorUnitSymbol",
                table: "Currency",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinorUnitSymbol",
                table: "Currency",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumericCode",
                table: "Currency",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RatioOfMinorUnit",
                table: "Currency",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Currency",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidFrom",
                table: "Currency",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidTo",
                table: "Currency",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Country",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "IsoCode",
                table: "Country",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Capital",
                table: "Country",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Country",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Country",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCountry",
                table: "Country",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLoyaltyProgram",
                table: "Country",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NativeName",
                table: "Country",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumericCode",
                table: "Country",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficialName",
                table: "Country",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Country",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidFrom",
                table: "Country",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidTo",
                table: "Country",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "Currency");

            migrationBuilder.DropColumn(
                name: "IsIsoCurrency",
                table: "Currency");

            migrationBuilder.DropColumn(
                name: "MajorUnitSymbol",
                table: "Currency");

            migrationBuilder.DropColumn(
                name: "MinorUnitSymbol",
                table: "Currency");

            migrationBuilder.DropColumn(
                name: "NumericCode",
                table: "Currency");

            migrationBuilder.DropColumn(
                name: "RatioOfMinorUnit",
                table: "Currency");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Currency");

            migrationBuilder.DropColumn(
                name: "ValidFrom",
                table: "Currency");

            migrationBuilder.DropColumn(
                name: "ValidTo",
                table: "Currency");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "IsCountry",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "IsLoyaltyProgram",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "NativeName",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "NumericCode",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "OfficialName",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "ValidFrom",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "ValidTo",
                table: "Country");

            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "Currency",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Currency",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Currency",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Country",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IsoCode",
                table: "Country",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Capital",
                table: "Country",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
