using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthenticationApi.Entities
{
    public class User_Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_vehicleId { get; set; }
        public string userFK { get; set; }=String.Empty;
        public User? user { get; set; }
        public int vehicleFK { get; set; }
        public Vehicle? vehicle { get; set; }

        public string user_vehicleDescription { get; set; } = String.Empty;
        public virtual ICollection<Offer>? Offers { get; set; }

    }
}
