using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    public partial class AddDoorCards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "DoorCards");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "DoorCards");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "DoorCards",
                newName: "IssueDate");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "DoorCards",
                newName: "CardNumber");

            migrationBuilder.AddColumn<int>(
                name: "AccessPermissionsId",
                table: "DoorCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "DoorCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PermissionName",
                table: "AccessPermissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_DoorCards_AccessPermissionsId",
                table: "DoorCards",
                column: "AccessPermissionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoorCards_AccessPermissions_AccessPermissionsId",
                table: "DoorCards",
                column: "AccessPermissionsId",
                principalTable: "AccessPermissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoorCards_AccessPermissions_AccessPermissionsId",
                table: "DoorCards");

            migrationBuilder.DropIndex(
                name: "IX_DoorCards_AccessPermissionsId",
                table: "DoorCards");

            migrationBuilder.DropColumn(
                name: "AccessPermissionsId",
                table: "DoorCards");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "DoorCards");

            migrationBuilder.DropColumn(
                name: "PermissionName",
                table: "AccessPermissions");

            migrationBuilder.RenameColumn(
                name: "IssueDate",
                table: "DoorCards",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "CardNumber",
                table: "DoorCards",
                newName: "Key");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "DoorCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "DoorCards",
                type: "datetime2",
                nullable: true);
        }
    }
}
