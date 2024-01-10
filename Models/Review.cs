using System.ComponentModel.DataAnnotations;

namespace myportfolio.Models
{
    public class Review
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int Rating { get; set; }
        public DateTime? Created_at { get; set; }
    }
}
