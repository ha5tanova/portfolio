using System.ComponentModel.DataAnnotations;

namespace myportfolio.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateOnly Start_date { get; set; }
        public DateOnly End_date { get; set; }
    }
}
