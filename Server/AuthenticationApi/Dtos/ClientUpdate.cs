using System.ComponentModel.DataAnnotations;

namespace AuthenticationApi.Dtos
{
    public class ClientUpdate
    {
        [Required] public string firstLastName { get; set; } = String.Empty;
        [Required]
        public string email { get; set; } = String.Empty;
        [Required]
        public string adress { get; set; } = String.Empty;
        [Required]
        public int phoneNumber { get; set; }
    }
}
