namespace Template.Abstractions.Services
{
    using Template.Domain.Entities;

    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
        //UserModel GetUserById(int id);
    }
}
