using Application.Commons.Interfaces;
using Application.Users.Responses;
using Dapper;
using Domain.Commons.Abstractions;

namespace Application.Users.GetUsers;


internal sealed class GetUsersQueryHandler : IQueryHandler<GetUsersQuery, List<UserResponse>>
{
    private readonly ISqlConnectionFactory _connectionFactory;

    public GetUsersQueryHandler(ISqlConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<Result<List<UserResponse>>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        using var connection = _connectionFactory.CreateConnection();

        const string sql = """
            SELECT 
                U.usuId AS UsuId,
                U.nombre AS Nombre,
                U.apellido AS Apellido
            FROM Usuario U
            """;

        var users = await connection.QueryAsync<UserResponse>(sql);

        return new Result<List<UserResponse>>(users.ToList(), true, null!);
    }
}
