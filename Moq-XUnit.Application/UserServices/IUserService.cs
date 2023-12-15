using Moq_XUnit.Domain.Dtos;
using Moq_XUnit.Domain.Entities;

namespace Moq_XUnit.Application.UserServices
{
    public interface IUserService
    {
        public ValueTask<bool> UserCreateAsync(UserDto userDto);
        public ValueTask<bool> UserUpdateAsync(int Id , UserDto userDto);
        public ValueTask<bool> UserDeleteAsync(int Id);
        public ValueTask<IEnumerable<User>> UserGetAllAsync();
        public ValueTask<User> UserGetByIdAsync(int Id);
    }
}
