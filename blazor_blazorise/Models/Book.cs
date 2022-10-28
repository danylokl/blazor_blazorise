using blazor_blazorise.Models;
using System.ComponentModel.DataAnnotations;

namespace blazor_blazorise.Models
{
    public class Book
    {
        [Required]
        public string Title { get; set; }
        public string Cover { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Content { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
