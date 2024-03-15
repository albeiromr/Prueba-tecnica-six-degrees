using Application.Users.Responses;
using Domain.Users;

namespace Application.Commons.Interfaces;

public interface IUserRepository
{
    Task<List<UserResponse>> GetUsersAsync(CancellationToken cancellationToken = default);
}
