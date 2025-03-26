using System.ComponentModel.DataAnnotations;

namespace TDBA.Data
{
    public class EventModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter an event name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select an age group.")]
        public string AgeGroup { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a price range.")]
        public string PriceRange { get; set; } = string.Empty;

        public bool IsIndoor { get; set; }
    }
}
