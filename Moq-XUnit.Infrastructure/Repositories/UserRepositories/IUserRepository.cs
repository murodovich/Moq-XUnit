using Moq_XUnit.Domain.Dtos;
using Moq_XUnit.Domain.Entities;

namespace Moq_XUnit.Infrastructure.Repositories.UserRepositories
{
    public interface IUserRepository
    {
        public ValueTask<bool> CreateAsync(UserDto userDto);
        public ValueTask<bool> UpdateAsync(int Id,UserDto userDto);
        public ValueTask<bool> DeleteAsync(int Id);
        public ValueTask<List<User>> GetAllAsync();
        public ValueTask<User> GetByIdAsync(int Id);

    }
}
