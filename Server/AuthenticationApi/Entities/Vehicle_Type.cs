using System.ComponentModel.DataAnnotations;

namespace AuthenticationApi.Entities
{
    public class Vehicle_Type
    {
        public int vehicle_typeId { get; set; }
        [Required]
        [StringLength(30)]
        public string vehicle_typeName { get; set; }=String.Empty;
        public virtual ICollection<Vehicle>? Vehicles { get; set; }

    }
}
