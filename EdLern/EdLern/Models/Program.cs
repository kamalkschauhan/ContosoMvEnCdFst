using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdLern.Models
{
    public class Program
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Program name cannot be longer than 100 characters.")]
        [Display(Name = "Program name")]
        [Column("ProgramName")]
        public string ProgramName { get; set; }

        [StringLength(200, ErrorMessage = "Program description cannot be longer than 200 characters.")]
        [Display(Name = "Program description")]
        [Column("ProgramDescription")]
        public string ProgramDescription { get; set; }

        [Display(Name = "Is Active")]
        [Column("IsActive")]
        public bool IsActive { get; set; } = true;
    }
}