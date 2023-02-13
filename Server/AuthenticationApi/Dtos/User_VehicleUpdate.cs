using System.ComponentModel.DataAnnotations;

namespace AuthenticationApi.Dtos
{
    public class User_VehicleUpdate
    {
        [Required]
        public string userFK { get; set; } = String.Empty;
        [Required]
        public int vehicleFK { get; set; }
        public string user_vehicleDescription { get; set; } = String.Empty;

    }
}
