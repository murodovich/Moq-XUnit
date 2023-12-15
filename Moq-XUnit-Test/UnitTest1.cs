using Moq;
using Moq_XUnit.Application.UserServices;
using Moq_XUnit.Domain.Entities;

namespace Moq_XUnit_Test
{
    public class UnitTest1
    {
        private readonly Mock<IUserService> userServiceMock;

        public UnitTest1(Mock<IUserService> userServiceMock)
        {
            userServiceMock = new Mock<IUserService>();
        }

        [Fact]
        public void GetAll_User_Test()
        {
            var res = GetUserData();

            userServiceMock.Setup(x => x.UserGetAllAsync())
                .Returns(res);
          
            
        }

        private List<User> GetUserData()
        {
            List<User> userdata = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Name = "Sarvar",
                    UserName = "murodovich",
                    Password = "sarvar0303",
                    Email = "sarvar@gmail.com",
                },
                new User()
                {
                    Id = 2,
                    Name = "Test",
                    UserName = "Test",
                    Password = "Test",
                    Email = "Test",
                }


            };
            return userdata;
        }
    }
}