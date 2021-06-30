using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Entities.Migrations
{
    public partial class EntitiesModelsAddEmployeeGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "EmployeeId",
                keyValue: new Guid("9ccf22ce-f597-4eb2-81be-2e0eb55d32c4"));

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "EmployeeId",
                keyValue: new Guid("e8261994-a28e-4e3c-9b24-232c70adaf3f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "IdOwner",
                keyValue: new Guid("71b2dd09-d155-400d-aa5e-83aeff3847c4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "IdOwner",
                keyValue: new Guid("72b003f7-70db-4254-b799-9894796e3acd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "IdOwner",
                keyValue: new Guid("7f3876b0-28ec-45b0-87be-998acffd49b0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "IdOwner",
                keyValue: new Guid("fdd54ed9-7de1-4527-90a0-a3172b63b203"));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "employee",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("b60547a2-b959-401c-abf8-374f7cf701d7"), new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "uncle.bob@gmail.com", "Uncle", null, "Bob", "999-888-7777" },
                    { new Guid("027bada6-38ee-4edf-9d22-90b9151b4431"), new DateTime(1981, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "jan.kirsten@gmail.com", "Jan", null, "Kirsten", "111-222-3333" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "IdOwner", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("c4ba5eb8-c6a0-4bfa-b5a5-3c789b9e1dba"), "61 Wellfield Road", new DateTime(1980, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Keen" },
                    { new Guid("ccac7938-d8a0-4d89-ae95-87bb2bde9175"), "27 Colored Row", new DateTime(1974, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna Bosh" },
                    { new Guid("98fb63ea-fdce-4558-936d-d733472c1546"), "91 Western Roads", new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sam Query" },
                    { new Guid("5f7d0bd4-f448-4b8c-b45f-c4bcb0732ae2"), "3 Edgar Buildings", new DateTime(1983, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin Miller" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "EmployeeId",
                keyValue: new Guid("027bada6-38ee-4edf-9d22-90b9151b4431"));

            migrationBuilder.DeleteData(
                table: "employee",
                keyColumn: "EmployeeId",
                keyValue: new Guid("b60547a2-b959-401c-abf8-374f7cf701d7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "IdOwner",
                keyValue: new Guid("5f7d0bd4-f448-4b8c-b45f-c4bcb0732ae2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "IdOwner",
                keyValue: new Guid("98fb63ea-fdce-4558-936d-d733472c1546"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "IdOwner",
                keyValue: new Guid("c4ba5eb8-c6a0-4bfa-b5a5-3c789b9e1dba"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "IdOwner",
                keyValue: new Guid("ccac7938-d8a0-4d89-ae95-87bb2bde9175"));

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "employee");

            migrationBuilder.InsertData(
                table: "employee",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("e8261994-a28e-4e3c-9b24-232c70adaf3f"), new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "uncle.bob@gmail.com", "Uncle", "Bob", "999-888-7777" },
                    { new Guid("9ccf22ce-f597-4eb2-81be-2e0eb55d32c4"), new DateTime(1981, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "jan.kirsten@gmail.com", "Jan", "Kirsten", "111-222-3333" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "IdOwner", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("7f3876b0-28ec-45b0-87be-998acffd49b0"), "61 Wellfield Road", new DateTime(1980, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Keen" },
                    { new Guid("71b2dd09-d155-400d-aa5e-83aeff3847c4"), "27 Colored Row", new DateTime(1974, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna Bosh" },
                    { new Guid("fdd54ed9-7de1-4527-90a0-a3172b63b203"), "91 Western Roads", new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sam Query" },
                    { new Guid("72b003f7-70db-4254-b799-9894796e3acd"), "3 Edgar Buildings", new DateTime(1983, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin Miller" }
                });
        }
    }
}
