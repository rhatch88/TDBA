using System.ComponentModel.DataAnnotations;

namespace TDBA.Data
{
    public class EventModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string AgeGroup { get; set; } = string.Empty;

        [Required]
        public string PriceRange { get; set; } = string.Empty;

        public bool IsIndoor { get; set; }
    }
}
