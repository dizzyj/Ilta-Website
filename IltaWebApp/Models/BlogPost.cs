using System.ComponentModel.DataAnnotations;

namespace IltaWebApp.Models
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ImageUrl {  get; set; }
        [Required, MaxLength(255)]
        public string Text { get; set; }
    }
}
