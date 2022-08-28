using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "ProductImages",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Caption",
                table: "ProductImages",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3b1d4a8-7ee8-458c-888a-0ef520f034a1"),
                column: "ConcurrencyStamp",
                value: "3b6dc705-5749-4629-845d-940f5f9978b0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("12ab94e9-a05a-45b1-bbbc-baae44360f84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de583352-6723-4c82-b50f-f5b07cd32deb", "AQAAAAEAACcQAAAAENCxasslaq+3R64gQmncYFjDrfLHvUjE0RUlL1ctxm5rzyjSkCZdbhhKCIDybY5fAQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 27, 18, 5, 59, 368, DateTimeKind.Local).AddTicks(4972));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Caption",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3b1d4a8-7ee8-458c-888a-0ef520f034a1"),
                column: "ConcurrencyStamp",
                value: "e01bdef0-19d6-4b93-be21-710bc64e04d6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("12ab94e9-a05a-45b1-bbbc-baae44360f84"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "facb654f-563d-48fd-aa7c-cec146eecbb9", "AQAAAAEAACcQAAAAEMDV4y85Rb1vFkV23LRIqrSszCM56JO9EJJSE6bdt0ZwYq/x+pRzLD0U6ad1JHz8qw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 26, 13, 35, 33, 338, DateTimeKind.Local).AddTicks(4358));
        }
    }
}
