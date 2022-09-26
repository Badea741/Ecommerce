using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Shared.Migrations
{
    public partial class AssignRoleToAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Product",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 26, 22, 57, 1, 755, DateTimeKind.Local).AddTicks(8905),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 26, 22, 55, 34, 674, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ConcurrencyStamp",
                table: "Product",
                type: "timestamp(6)",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldRowVersion: true,
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "214cacc5-fc13-4167-8d9d-76fdf7cc4616",
                column: "ConcurrencyStamp",
                value: "199cd8b7-a8fe-43ed-af6e-7c55a29e2ae4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ded354e-6f24-4f5d-a8c6-5a1377cf9372",
                column: "ConcurrencyStamp",
                value: "3834df67-d0f1-43e7-b8b4-333acf4a4f62");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7ded354e-6f24-4f5d-a8c6-5a1377cf9372", "7ded354e-6f24-4f5d-a8c6-5a1377cf9371" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ded354e-6f24-4f5d-a8c6-5a1377cf9371",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11829d67-db34-429d-92b8-7d5436a9cbec", "AQAAAAEAACcQAAAAELKHQFXSxEJAFLlIfLxZMY34GxQUqmMICI7OoZYGPhSPzITbh2w9d3pfbJI7pDch1A==", "195c40a1-7d70-408b-b812-63c89d172cc0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ded354e-6f24-4f5d-a8c6-5a1377cf9372", "7ded354e-6f24-4f5d-a8c6-5a1377cf9371" });

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Product",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 26, 22, 55, 34, 674, DateTimeKind.Local).AddTicks(4249),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 26, 22, 57, 1, 755, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ConcurrencyStamp",
                table: "Product",
                type: "timestamp(6)",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "214cacc5-fc13-4167-8d9d-76fdf7cc4616",
                column: "ConcurrencyStamp",
                value: "cd6ce332-0107-43d6-b501-e2484ee68bf2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ded354e-6f24-4f5d-a8c6-5a1377cf9372",
                column: "ConcurrencyStamp",
                value: "caeef544-3a30-44f0-bce1-17f6e503d7a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ded354e-6f24-4f5d-a8c6-5a1377cf9371",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2deb3d31-38a8-4210-88e7-d5f988e653e9", "AQAAAAEAACcQAAAAEEVFL+N/1qezH2L/CRHyvgWdTxRP0J+eqKAxJ1NpN717QoI4DszWAaKdVlxAV1fVeA==", "ea344cd3-0530-41a3-bd81-2353bd9d35b6" });
        }
    }
}
