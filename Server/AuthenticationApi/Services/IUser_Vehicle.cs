﻿using AuthenticationApi.Dtos;
using AuthenticationApi.Entities;

namespace AuthenticationApi.Services
{
    public interface IUser_Vehicle
    {
        IEnumerable<User_Vehicle> GetAllUser_Vehicle();

        void CreateUser_Vehicle(User_VehicleCreation model);
        void DeleteUser_Vehicle(int id);
        void UpdateUser_Vehicle(int id, User_VehicleUpdate model);
    }
}
