using Moq_XUnit.Domain.Dtos;
using Moq_XUnit.Domain.Entities;
using Moq_XUnit.Infrastructure.Repositories.UserRepositories;
namespace Moq_XUnit.Application.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async ValueTask<bool> UserCreateAsync(UserDto userDto)
        {
            var result = await _userRepository.CreateAsync(userDto);
            return result;
        }

        public async ValueTask<bool> UserDeleteAsync(int Id)
        {
            var result = await _userRepository.DeleteAsync(Id);
            return result;
        }

        public async ValueTask<IEnumerable<User>> UserGetAllAsync()
        {
            var result = await _userRepository.GetAllAsync();
            return result;
        }

        public async ValueTask<User> UserGetByIdAsync(int Id)
        {
            var result = await (_userRepository.GetByIdAsync(Id));
            return result;
        }

        public async ValueTask<bool> UserUpdateAsync(int Id, UserDto userDto)
        {
            var result = await _userRepository.UpdateAsync(Id, userDto);
            return result;
        }
    }
}
