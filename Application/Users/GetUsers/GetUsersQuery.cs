using Application.Commons.Interfaces;
using Domain.Users;

namespace Application.Users.GetUsers;

public sealed record GetUsersQuery(
    Guid rentalId
) : IQuery<List<Usuario>>;
