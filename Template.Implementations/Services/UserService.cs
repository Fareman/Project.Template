namespace Template.Implementations.Services
{
    using System.Collections.Generic;
    using Template.Abstractions.Repositories;
    using Template.Abstractions.Services;
    using Template.Domain.Entities;

    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }


        //public Task<IEnumerable<UserModel>> GetUserById(int id)
        //{
        //    return await _repository.GetUsersAsync();
        //}

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _repository.GetUsersAsync();
        }
    }
}
