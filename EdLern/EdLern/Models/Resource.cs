using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdLern.Models
{
    public class Resource
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Resource name cannot be longer than 100 characters.")]
        [Display(Name = "Resource name")]
        [Column("ResourceName")]
        public string ResourceName { get; set; }

        [StringLength(200, ErrorMessage = "Resource description cannot be longer than 200 characters.")]
        [Display(Name = "Resource description")]
        [Column("ResourceDescription")]
        public string ResourceDescription { get; set; }

        [Required]
        [Display(Name = "Age group")]
        [Column("AgeGroup")]
        public virtual ICollection<AgeGroup> AgeGroups { get; set; }

        [Display(Name = "Is Active")]
        [Column("IsActive")]
        public bool IsActive { get; set; } = true;
    }

    public class AgeGroup
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Age group cannot be longer than 10 characters.")]
        [Display(Name = "Age group")]
        [Column("AgeGroupName")]
        public string AgeGroupName { get; set; }

        [StringLength(200, ErrorMessage = "Age group description cannot be longer than 200 characters.")]
        [Display(Name = "Age group description")]
        [Column("AgeGroupDescription")]
        public string AgeGroupDescription { get; set; }

        [Display(Name = "Is Active")]
        [Column("IsActive")]
        public bool IsActive { get; set; } = true;
    }
}