using Application.Commons.Constants;
using Application.Commons.Interfaces;
using Application.Users.Responses;
using Domain.Commons.Abstractions;

namespace Application.Users.GetUsers;


internal sealed class GetUsersQueryHandler : IQueryHandler<GetUsersQuery, List<UserResponse>>
{
    private readonly IUserRepository? _userRepository;

    public GetUsersQueryHandler(IUserRepository? userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<List<UserResponse>>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var users = await _userRepository!.GetUsersAsync(cancellationToken);
            return new Result<List<UserResponse>>(users, true, null!);

        } catch (Exception ex)
        {
            return new Result<List<UserResponse>>(default!, false, new Error(
                UsersConstants.UsersQueryError!,
                ex.Message
            ));
        }
    }
}
