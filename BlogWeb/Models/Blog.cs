using System.ComponentModel.DataAnnotations;

namespace BlogWeb.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        [Required]
        [StringLength(100)]
        public string? BlogTitle { get; set; }

        [Required]
        [StringLength(250)]
        public string? BlogPrelude { get; set; }

        [Required]
        public DateTime BlogDate { get; set; } = DateTime.Today;

        [Required]
        public string? BlogKeyword1 { get; set; }

        public string? BlogKeyword2 { get; set; }

        public string? BlogKeyword3 { get; set; }

        [Required]
        public string? BlogArticle { get; set; }

        [Required]
        public string? BlogImageUrl1 { get; set; }

        public string? BlogImageUrl2 { get; set; }

        public string? BlogImageUrl3 { get; set; }
    }
}
