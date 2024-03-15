using Application.Commons.Interfaces;
using Application.Users.Responses;
using Domain.Users;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class UserRepository : IUserRepository
{
    private readonly AppDbContext? _appdbContext;

    public UserRepository(AppDbContext? appdbContext)
    {
        _appdbContext = appdbContext;
    }

    public async Task<List<UserResponse>> GetUsersAsync(CancellationToken cancellationToken = default)
    {
        var dbSet = _appdbContext!.Set<Usuario>();
        var dbUsers = await dbSet.ToListAsync();

        List<UserResponse> users = new List<UserResponse>();
        foreach (var user in dbUsers)
        {
            var response = new UserResponse(user.UsuID, user.Nombre, user.Apellido);
            users.Add(response);
        }

        return users;
    }
}
