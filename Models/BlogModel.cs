using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netMvcApp.Models
{
    [Table("Blog")]
    public class BlogModel
    {
        [Key]
        // [Column("BLogId")]
        public int Blog_Id { get; set; }
        public string? Blog_Title { get; set; }
        public string? Blog_Author { get; set; }
        public string? Blog_Content { get; set; }
    }
}