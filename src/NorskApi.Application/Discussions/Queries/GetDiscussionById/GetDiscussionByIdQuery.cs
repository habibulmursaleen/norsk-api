using ErrorOr;
using MediatR;
using NorskApi.Application.Discussions.Models;

namespace NorskApi.Application.Discussions.Queries.GetDiscussionById;

public record GetDiscussionByIdQuery(Guid EssayId, Guid Id) : IRequest<ErrorOr<DiscussionResult>>;