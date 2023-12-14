using Microsoft.EntityFrameworkCore;
using Moq_XUnit.Domain.Dtos;
using Moq_XUnit.Domain.Entities;
using Moq_XUnit.Domain.Exceptions;
using Moq_XUnit.Infrastructure.Persistance;

namespace Moq_XUnit.Infrastructure.Repositories.UserRepositories
{
    public class UserRepisitory : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepisitory(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async ValueTask<bool> CreateAsync(UserDto userDto)
        {
            User user = new User()
            {
                Name = userDto.Name,
                Email = userDto.Email,
                UserName = userDto.UserName,
                Password = userDto.Password,
            };

            await _appDbContext.Users.AddAsync(user);

            var res = await _appDbContext.SaveChangesAsync();
            return res > 0;
        }

        public async ValueTask<bool> DeleteAsync(int Id)
        {
            var result = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == Id);
            if (result == null) throw new UserNotFoundException();

            _appDbContext.Users.Remove(result);
            var res = await _appDbContext.SaveChangesAsync();
            return res > 0;
        }

        public async ValueTask<List<User>> GetAllAsync()
        {
            var result = await _appDbContext.Users.ToListAsync();
            return result;
        }

        public async ValueTask<User> GetByIdAsync(int Id)
        {
            var result = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == Id);
            if (result == null) throw new UserNotFoundException();
            return result;
        }

        public async ValueTask<bool> UpdateAsync(int Id, UserDto userDto)
        {
            var result = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == Id);

            if (result == null) throw new UserNotFoundException();

            result.Name = userDto.Name;
            result.Email = userDto.Email;
            result.Password = userDto.Password;
            result.UserName = userDto.UserName;

            var res = await _appDbContext.SaveChangesAsync();
            return res > 0;
        }
    }
}
