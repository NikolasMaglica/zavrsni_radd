using System.ComponentModel.DataAnnotations;

namespace AuthenticationApi.Dtos
{
    public class User_VehicleCreation
    {
        [Required]
        public string userFK { get; set; } = string.Empty;
        [Required]
        public int vehicleFK { get; set; }
        public string user_vehicleDescription { get; set;}
    }
}
