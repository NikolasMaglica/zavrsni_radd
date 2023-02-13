using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthenticationApi.Migrations
{
    public partial class kk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "vehicle_typename",
                table: "Vehicle_Types",
                newName: "vehicle_typeName");

            migrationBuilder.RenameColumn(
                name: "phonenumber",
                table: "Clients",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "firstlastname",
                table: "Clients",
                newName: "firstLastName");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Clients",
                newName: "adress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "vehicle_typeName",
                table: "Vehicle_Types",
                newName: "vehicle_typename");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "Clients",
                newName: "phonenumber");

            migrationBuilder.RenameColumn(
                name: "firstLastName",
                table: "Clients",
                newName: "firstlastname");

            migrationBuilder.RenameColumn(
                name: "adress",
                table: "Clients",
                newName: "Adress");
        }
    }
}
