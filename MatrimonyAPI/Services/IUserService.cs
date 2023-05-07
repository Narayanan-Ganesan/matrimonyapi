using MatrimonyAPI.Requests;
using MatrimonyAPI.Responses;

namespace MatrimonyAPI.Services
{
    public interface IUserService
    {
        Task<ResponseDto<UserDto>> CreateUserAsync(UserRequest userRequest);

        Task<ResponseDto<UserDto>> GetUserbyIDAsync(string ID);
    }
}
