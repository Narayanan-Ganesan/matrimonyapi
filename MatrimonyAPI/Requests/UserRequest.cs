using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MatrimonyAPI.Requests
{
    public class UserRequest
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Name cannot be empty")]
        [MaxLength(length:100,ErrorMessage ="Name cannot be greater than 100 character")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Father's Name cannot be empty")]
        [MaxLength(length: 100, ErrorMessage = "Father's Name cannot be greater than 100 character")]
        public string FatherName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mother's Name cannot be empty")]
        [MaxLength(length: 100, ErrorMessage = "Mother's Name cannot be greater than 100 character")]
        public string MotherName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "MaritalStatus cannot be empty")]
        [MaxLength(length: 50, ErrorMessage = "MaritalStatus cannot be greater than 50 character")]
        public string MaritalStatus { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Gender cannot be empty")]
        [MaxLength(length: 1, ErrorMessage = "Gender cannot be greater than 1 character")]
        [RegularExpression("[MF]",ErrorMessage ="Gender can be either M or F")]
        public string Gender { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Caste cannot be empty")]
        [MaxLength(length: 100, ErrorMessage = "Caste cannot be greater than 100 character")]
        public string Caste { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Kulam cannot be empty")]
        [MaxLength(length: 100, ErrorMessage = "Kulam cannot be greater than 100 character")]
        public string Kulam { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Kovil cannot be empty")]
        [MaxLength(length: 100, ErrorMessage = "Kovil cannot be greater than 100 character")]
        public string Kovil { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Star cannot be empty")]
        [MaxLength(length: 100, ErrorMessage = "Star cannot be greater than 100 character")]
        public string Star { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Zodiac cannot be empty")]
        [MaxLength(length: 100, ErrorMessage = "Zodiac cannot be greater than 100 character")]
        public string Zodiac { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Occupation cannot be empty")]
        [MaxLength(length: 100, ErrorMessage = "Occupation cannot be greater than 100 character")]
        public string Occupation { get; set; }
    }
}
