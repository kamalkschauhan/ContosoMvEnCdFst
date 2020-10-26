using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdLern.Models
{
    public class Blog
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Blog name cannot be longer than 100 characters.")]
        [Display(Name = "Blog name")]
        [Column("BlogName")]
        public string BlogName { get; set; }
        
        [StringLength(200, ErrorMessage = "Blog description cannot be longer than 200 characters.")]
        [Display(Name = "Blog description")]
        [Column("BlogDescription")]
        public string BlogDescription { get; set; }

        [Display(Name = "Is Active")]
        [Column("IsActive")]
        public bool IsActive { get; set; } = true;
    }
}