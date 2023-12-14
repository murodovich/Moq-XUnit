namespace Moq_XUnit.Domain.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base("User not Found!") { }
    }
}
