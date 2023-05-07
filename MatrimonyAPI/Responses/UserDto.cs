using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MatrimonyAPI.Responses
{
    public class UserDto
    {
        public string MatrimonyID { get; set;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public int Age { get; set; }
        public string Caste { get; set; }
        public string Kulam { get; set; }
        public string Kovil { get; set; }
        public string Star { get; set; }
        public string Zodiac { get; set; }
        public string Occupation { get; set; }
        public bool isActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
