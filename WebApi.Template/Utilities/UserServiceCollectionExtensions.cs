namespace Template.WebApi.Utilities
{
    using Microsoft.Extensions.DependencyInjection;
    using Template.Abstractions.Repositories;
    using Template.Abstractions.Services;
    using Template.Implementations.Database;
    using Template.Implementations.Repositories;
    using Template.Implementations.Services;

    public static class UserServiceCollectionExtensions
    {
        public static IServiceCollection AddUserModule(this IServiceCollection services)
        {
            services.AddDbContext<UserContext>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddAutoMapper(typeof(UserMappingProfile));

            return services;
        }
    }
}
