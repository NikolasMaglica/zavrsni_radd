using System.ComponentModel.DataAnnotations;

namespace AuthenticationApi.Entities
{
    public class Vehicle
    {
        public int vehicleId { get; set; }
        [Required]
        [StringLength(40)]
        public string manufacturer { get; set; } = String.Empty;
        [Required]
        [StringLength(40)]
        public string model { get; set; } = String.Empty;
        [Required]
        [MaxLength(20)]
        public int productionYear { get; set; }
        [Required]
        [MaxLength(20)]
        public float kilometersTraveled { get; set; }
        [Required]
        public int vehicle_typeFK { get; set; }

        public virtual Vehicle_Type? vehicle_type { get; set; }
        [Required]
        public int clientFK { get; set; }

        public virtual Client? client { get; set; }
        public ICollection<User_Vehicle>? user_vehicle { get; set; }


    }
}
