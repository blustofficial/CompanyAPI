using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyAPI.Database.Migrations
{
    /// <inheritdoc />
    public partial class Refactoring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Users",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Users",
                newName: "role_id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Users",
                newName: "email_verified_at");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Statements",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Statements",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Statements",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Statements",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Statements",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Statements",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "News",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "News",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "News",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "News",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "News",
                newName: "company_id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "News",
                newName: "deleted_at");

            migrationBuilder.AddColumn<int>(
                name: "company_id",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "remember_token",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "Statements",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "rating",
                table: "Statements",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Statements",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "News",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "News",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "company_id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "remember_token",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "title",
                table: "Statements");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "News");

            migrationBuilder.DropColumn(
                name: "image",
                table: "News");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Users",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "role_id",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "email_verified_at",
                table: "Users",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Statements",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Statements",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Statements",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Statements",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Statements",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "Statements",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "News",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "News",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "News",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "News",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "News",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "company_id",
                table: "News",
                newName: "ParentId");
        }
    }
}
