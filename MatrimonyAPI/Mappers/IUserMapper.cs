using MatrimonyAPI.Domain;
using MatrimonyAPI.Requests;
using MatrimonyAPI.Responses;

namespace MatrimonyAPI.Mappers
{
    public interface IUserMapper
    {
        User MapFrom(UserRequest user);
        UserDto MapDto(User user);
    }
}
