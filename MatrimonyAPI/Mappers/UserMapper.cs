using MatrimonyAPI.Domain;
using MatrimonyAPI.Requests;
using MatrimonyAPI.Responses;

namespace MatrimonyAPI.Mappers
{
    public class UserMapper : IUserMapper
    {
        public User MapFrom(UserRequest user)
        {
            return new User
            {
                Name = user.Name,
                FatherName = user.FatherName,
                MotherName = user.MotherName,
                MaritalStatus = user.MaritalStatus,
                Gender = user.Gender,
                DateofBirth = user.DateofBirth.Date,
                Caste = user.Caste,
                Kulam = user.Kulam,
                Kovil = user.Kovil,
                Star = user.Star,
                Zodiac = user.Zodiac,
                Occupation = user.Occupation,
                isActive = true,
                CreatedDate = DateTime.Now,
                MatrimonyID = string.Empty
            };
        }
        public UserDto MapDto(User user)
        {
            return new UserDto
            {
                MatrimonyID = user.MatrimonyID,
                Name = user.Name,
                FatherName = user.FatherName,
                MotherName = user.MotherName,
                MaritalStatus = user.MaritalStatus,
                Gender = user.Gender,
                DateofBirth = user.DateofBirth,
                Caste = user.Caste,
                Kulam = user.Kulam,
                Kovil = user.Kovil,
                Star = user.Star,
                Zodiac = user.Zodiac,
                Occupation = user.Occupation,
                CreatedDate = user.CreatedDate,
                isActive = user.isActive,
                Age = AgeCalculator(user.DateofBirth)
            };
        }
        private int AgeCalculator(DateTime dob)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - dob.Year;
            if (dob > now.AddYears(-age))
                age--;
            return age;
        }
    }
}
