using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdLern.Models
{
    public class Consultation
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Consultation name cannot be longer than 100 characters.")]
        [Display(Name = "Consultation name")]
        [Column("ConsultationName")]
        public string ConsultationName { get; set; }

        [StringLength(200, ErrorMessage = "Consultation description cannot be longer than 200 characters.")]
        [Display(Name = "Consultation description")]
        [Column("ConsultationDescription")]
        public string ConsultationDescription { get; set; }

        [Display(Name = "Is Active")]
        [Column("IsActive")]
        public bool IsActive { get; set; } = true;
    }
}