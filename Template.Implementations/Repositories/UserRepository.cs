namespace Template.Implementations.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using Template.Abstractions.Repositories;
    using Template.Domain.Entities;
    using Template.Implementations.Database;

    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.AsNoTracking().ToListAsync();
        }
    }
}
