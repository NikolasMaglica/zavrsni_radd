using System.ComponentModel.DataAnnotations;

namespace AuthenticationApi.Dtos
{
    public class VehicleUpdate
    {
        [Required]
        public string manufacturer { get; set; } = String.Empty;
        [Required]
        public string model { get; set; } = String.Empty;
        [Required]
        public int productionYear { get; set; }
        [Required]
        public float kilometersTraveled { get; set; }
        [Required]
        public int vehicle_typeFK { get; set; }
        [Required]
        public int clientFK { get; set; }
    }
}
