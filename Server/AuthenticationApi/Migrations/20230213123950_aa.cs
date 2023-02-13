using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthenticationApi.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Vehicles_vehicleid",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Vehicle_AspNetUsers_userid",
                table: "User_Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Vehicle_Vehicles_vehicleid",
                table: "User_Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Clients_clientid",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Vehicle_Types_vehicle_typeid",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Offers_vehicleid",
                table: "Offers");

            migrationBuilder.RenameColumn(
                name: "productionyear",
                table: "Vehicles",
                newName: "productionYear");

            migrationBuilder.RenameColumn(
                name: "kilometerstraveled",
                table: "Vehicles",
                newName: "kilometersTraveled");

            migrationBuilder.RenameColumn(
                name: "vehicle_typeid",
                table: "Vehicles",
                newName: "vehicle_typeFK");

            migrationBuilder.RenameColumn(
                name: "clientid",
                table: "Vehicles",
                newName: "clientFK");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Vehicles",
                newName: "vehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_vehicle_typeid",
                table: "Vehicles",
                newName: "IX_Vehicles_vehicle_typeFK");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_clientid",
                table: "Vehicles",
                newName: "IX_Vehicles_clientFK");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Vehicle_Types",
                newName: "vehicle_typeId");

            migrationBuilder.RenameColumn(
                name: "vehicleid",
                table: "User_Vehicle",
                newName: "vehicleFK");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "User_Vehicle",
                newName: "userFK");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "User_Vehicle",
                newName: "user_vehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_User_Vehicle_vehicleid",
                table: "User_Vehicle",
                newName: "IX_User_Vehicle_vehicleFK");

            migrationBuilder.RenameIndex(
                name: "IX_User_Vehicle_userid",
                table: "User_Vehicle",
                newName: "IX_User_Vehicle_userFK");

            migrationBuilder.RenameColumn(
                name: "vehicleid",
                table: "Offers",
                newName: "user_vehicleFK");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Clients",
                newName: "clientId");

            migrationBuilder.AddColumn<int>(
                name: "user_vehicleId",
                table: "Offers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_user_vehicleId",
                table: "Offers",
                column: "user_vehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_User_Vehicle_user_vehicleId",
                table: "Offers",
                column: "user_vehicleId",
                principalTable: "User_Vehicle",
                principalColumn: "user_vehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Vehicle_AspNetUsers_userFK",
                table: "User_Vehicle",
                column: "userFK",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Vehicle_Vehicles_vehicleFK",
                table: "User_Vehicle",
                column: "vehicleFK",
                principalTable: "Vehicles",
                principalColumn: "vehicleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Clients_clientFK",
                table: "Vehicles",
                column: "clientFK",
                principalTable: "Clients",
                principalColumn: "clientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Vehicle_Types_vehicle_typeFK",
                table: "Vehicles",
                column: "vehicle_typeFK",
                principalTable: "Vehicle_Types",
                principalColumn: "vehicle_typeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_User_Vehicle_user_vehicleId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Vehicle_AspNetUsers_userFK",
                table: "User_Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Vehicle_Vehicles_vehicleFK",
                table: "User_Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Clients_clientFK",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Vehicle_Types_vehicle_typeFK",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Offers_user_vehicleId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "user_vehicleId",
                table: "Offers");

            migrationBuilder.RenameColumn(
                name: "productionYear",
                table: "Vehicles",
                newName: "productionyear");

            migrationBuilder.RenameColumn(
                name: "kilometersTraveled",
                table: "Vehicles",
                newName: "kilometerstraveled");

            migrationBuilder.RenameColumn(
                name: "vehicle_typeFK",
                table: "Vehicles",
                newName: "vehicle_typeid");

            migrationBuilder.RenameColumn(
                name: "clientFK",
                table: "Vehicles",
                newName: "clientid");

            migrationBuilder.RenameColumn(
                name: "vehicleId",
                table: "Vehicles",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_vehicle_typeFK",
                table: "Vehicles",
                newName: "IX_Vehicles_vehicle_typeid");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_clientFK",
                table: "Vehicles",
                newName: "IX_Vehicles_clientid");

            migrationBuilder.RenameColumn(
                name: "vehicle_typeId",
                table: "Vehicle_Types",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "vehicleFK",
                table: "User_Vehicle",
                newName: "vehicleid");

            migrationBuilder.RenameColumn(
                name: "userFK",
                table: "User_Vehicle",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "user_vehicleId",
                table: "User_Vehicle",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_User_Vehicle_vehicleFK",
                table: "User_Vehicle",
                newName: "IX_User_Vehicle_vehicleid");

            migrationBuilder.RenameIndex(
                name: "IX_User_Vehicle_userFK",
                table: "User_Vehicle",
                newName: "IX_User_Vehicle_userid");

            migrationBuilder.RenameColumn(
                name: "user_vehicleFK",
                table: "Offers",
                newName: "vehicleid");

            migrationBuilder.RenameColumn(
                name: "clientId",
                table: "Clients",
                newName: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_vehicleid",
                table: "Offers",
                column: "vehicleid");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Vehicles_vehicleid",
                table: "Offers",
                column: "vehicleid",
                principalTable: "Vehicles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Vehicle_AspNetUsers_userid",
                table: "User_Vehicle",
                column: "userid",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Vehicle_Vehicles_vehicleid",
                table: "User_Vehicle",
                column: "vehicleid",
                principalTable: "Vehicles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Clients_clientid",
                table: "Vehicles",
                column: "clientid",
                principalTable: "Clients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Vehicle_Types_vehicle_typeid",
                table: "Vehicles",
                column: "vehicle_typeid",
                principalTable: "Vehicle_Types",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
