using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdLern.Models
{
    public class Class
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Class name cannot be longer than 100 characters.")]
        [Display(Name = "Class name")]
        [Column("ClassName")]
        public string ClassName { get; set; }
        
        [StringLength(200, ErrorMessage = "Class description cannot be longer than 200 characters.")]
        [Display(Name = "Class description")]
        [Column("ClassDescription")]
        public string ClassDescription { get; set; }

        [Display(Name = "Is Active")]
        [Column("IsActive")]
        public bool IsActive { get; set; } = true;

        public virtual ClassMode Modes { get; set; }
    }
    
    public enum ClassMode { Online, Recorded, Correspondence }
}