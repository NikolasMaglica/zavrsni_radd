using System.ComponentModel.DataAnnotations;

namespace AuthenticationApi.Entities
{
    public class Client
    {
        public int clientId { get; set; }
        [Required]
        [StringLength(40)]

        public string firstLastName { get; set; } = String.Empty;
        [Required]
        [StringLength(40)]

        public string email { get; set; } = String.Empty;
        [Required]
        [StringLength(40)]
  
        public string adress { get; set; } = String.Empty;
 
        [Required]
        [MaxLength(20)]
        public int phoneNumber { get; set; }
        public virtual ICollection<Vehicle>? Vehicles { get; set; }
        public virtual ICollection<Offer>? Offers { get; set; }


    }
}
