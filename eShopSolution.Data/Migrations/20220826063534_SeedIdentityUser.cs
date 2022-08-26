using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("e3b1d4a8-7ee8-458c-888a-0ef520f034a1"), "e01bdef0-19d6-4b93-be21-710bc64e04d6", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e3b1d4a8-7ee8-458c-888a-0ef520f034a1"), new Guid("12ab94e9-a05a-45b1-bbbc-baae44360f84") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("12ab94e9-a05a-45b1-bbbc-baae44360f84"), 0, "facb654f-563d-48fd-aa7c-cec146eecbb9", new DateTime(2001, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "danhdc2001@gmail.com", true, "Cong", "Danh", false, null, "danhdc2001@gmail.com", "admin", "AQAAAAEAACcQAAAAEMDV4y85Rb1vFkV23LRIqrSszCM56JO9EJJSE6bdt0ZwYq/x+pRzLD0U6ad1JHz8qw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 26, 13, 35, 33, 338, DateTimeKind.Local).AddTicks(4358));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3b1d4a8-7ee8-458c-888a-0ef520f034a1"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e3b1d4a8-7ee8-458c-888a-0ef520f034a1"), new Guid("12ab94e9-a05a-45b1-bbbc-baae44360f84") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("12ab94e9-a05a-45b1-bbbc-baae44360f84"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 26, 13, 20, 53, 54, DateTimeKind.Local).AddTicks(6437));
        }
    }
}
