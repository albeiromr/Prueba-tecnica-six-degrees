using Application.Commons.Interfaces;
using Application.Users.Responses;

namespace Application.Users.GetUsers;

public sealed record GetUsersQuery() : IQuery<List<UserResponse>>;
