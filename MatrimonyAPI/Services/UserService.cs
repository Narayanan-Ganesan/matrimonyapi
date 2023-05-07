using MatrimonyAPI.Domain;
using MatrimonyAPI.Mappers;
using MatrimonyAPI.Repositories;
using MatrimonyAPI.Requests;
using MatrimonyAPI.Responses;
using System;
using System.Net;

namespace MatrimonyAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserMapper _userMapper;
        private readonly IConfiguration _configuration;
        public UserService(IUserRepository userRepository, IUserMapper userMapper, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _userMapper = userMapper;
            _configuration = configuration;
        }
        public async Task<ResponseDto<UserDto>> CreateUserAsync(UserRequest userRequest)
        {
            var response = new ResponseDto<UserDto>();
            var newuser = MapFrom(userRequest);
            var recentUser = await _userRepository.GetLastUser();
            newuser.MatrimonyID = MatrimonyIDGenerator(recentUser);
            var user = await _userRepository.CreateUserAsync(newuser);

            if (user == null)
            {
                response.Message = "User creation failed";
                response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return response;
            }
            response.StatusCode = (int)HttpStatusCode.Created;
            response.Message = "User created successfully";
            response.Data = MapDto(user);
            return response;
        }
        public async Task<ResponseDto<UserDto>> GetUserbyIDAsync(string id)
        {
            var response = new ResponseDto<UserDto>();
            var user = await _userRepository.GetUserbyIDAsync(id);
            if (user == null)
            {
                response.StatusCode = (int)HttpStatusCode.NotFound;
                response.Message = $"Matrimony {id} not exists";
                return response;
            }
            response.StatusCode= (int)HttpStatusCode.Found;
            response.Message = $"Matrimony {id} exists";
            response.Data = MapDto(user);
            return response;
        }

        //Mapper
        private UserDto MapDto(User user)
        {
            var userdto = _userMapper.MapDto(user);
            return userdto;
        }
        private User MapFrom(UserRequest userRequest)
        {
            var user = _userMapper.MapFrom(userRequest);
            return user;
        }
        private string MatrimonyIDGenerator(User recentuser)
        {
            string code = _configuration.GetValue<string>("Code") ?? string.Empty;
            if (recentuser == null)
            {
                return code + String.Format("{0:D4}", 1);
            }
            var lastID = Convert.ToInt32(recentuser.MatrimonyID.Substring(3));
            return code + String.Format("{0:D4}", lastID + 1);
        }
    }
}


