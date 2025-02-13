using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IltaWebApp.Models.Entities
{
    public class BlogPost
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id")]
		public int Id { get; set; }

        [Column("created_at")]
		public DateTime CreatedAt { get; set; }

        [Column("Image_url")]
        public string ImageUrl {  get; set; }

        [Column("text")]
        [Required, MaxLength(255)]
        public string Text { get; set; }
    }
}
