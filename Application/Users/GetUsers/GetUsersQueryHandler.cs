using Application.Commons.Constants;
using Application.Commons.Interfaces;
using Domain.Commons.Abstractions;
using Domain.Users;

namespace Application.Users.GetUsers;


internal sealed class GetUsersQueryHandler : IQueryHandler<GetUsersQuery, List<Usuario>>
{
    private readonly IUserRepository? _userRepository;

    public GetUsersQueryHandler(IUserRepository? userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<List<Usuario>>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var users = await _userRepository!.GetUsersAsync(cancellationToken);
            return new Result<List<Usuario>>(users, true, null!);

        } catch (Exception ex)
        {
            return new Result<List<Usuario>>(default!, false, new Error(
                UsersConstants.UsersQueryError!,
                ex.Message
            ));
        }
    }
}
