using Domain.Users;

namespace Application.Commons.Interfaces;

public interface IUserRepository
{
    Task<List<Usuario>> GetUsersAsync(CancellationToken cancellationToken = default);
}
