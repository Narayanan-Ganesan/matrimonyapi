using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatrimonyAPI.Domain
{
    [Table("Users")]
    public class User
    {
        [Key]
        [MaxLength(7)]
        public string MatrimonyID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string FatherName { get; set; }
        [Required]
        [MaxLength(100)]
        public string MotherName { get; set; }
        [Required]
        [MaxLength(50)]
        public string MaritalStatus { get; set; }
        [Required]
        [MaxLength(1)]
        public string Gender { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
        [Required]
        [MaxLength(100)]
        public string Caste { get; set; }
        [Required]
        [MaxLength(100)]
        public string Kulam { get; set; }
        [Required]
        [MaxLength(100)]
        public string Kovil { get; set; }
        [Required]
        [MaxLength(100)]
        public string Star { get; set; }
        [Required]
        [MaxLength(100)]
        public string Zodiac { get; set; }
        [Required]
        [MaxLength(100)]
        public string Occupation { get; set; }
        [Required]
        [DefaultValue(true)]
        public bool isActive { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
