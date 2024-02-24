namespace Template.Abstractions.Repositories
{
    using Template.Domain.Entities;

    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();
    }
}
