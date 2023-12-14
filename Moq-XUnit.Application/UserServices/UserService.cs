using Moq_XUnit.Domain.Dtos;
using Moq_XUnit.Domain.Entities;

namespace Moq_XUnit.Application.UserServices
{
    public class UserService : IUserService
    {
        
        public ValueTask<bool> UserCreateAsync(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> UserDeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<User>> UserGetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<User> UserGetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> UserUpdateAsync(int Id, UserDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}
