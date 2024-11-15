using ErrorOr;
using MediatR;
using NorskApi.Application.Questions.Models;

namespace NorskApi.Application.Questions.Queries.GetQuestionById;

public record GetQuestionByIdQuery(Guid Id) : IRequest<ErrorOr<QuestionResult>>;
