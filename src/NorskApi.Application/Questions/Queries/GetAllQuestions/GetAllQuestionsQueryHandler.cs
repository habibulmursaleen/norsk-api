using ErrorOr;
using MediatR;
using NorskApi.Application.Common.Interfaces.Persistance;
using NorskApi.Application.Common.QueryParamsBuilder;
using NorskApi.Application.Questions.Models;
using NorskApi.Domain.EssayAggregate.ValueObjects;
using NorskApi.Domain.QuestionAggregate;

namespace NorskApi.Application.Questions.Queries.GetAllQuestions;

public class GetAllQuestionsQueryHandler
    : IRequestHandler<GetAllQuestionsQuery, ErrorOr<List<QuestionResult>>>
{
    private readonly IQuestionRepository questionRepository;

    public GetAllQuestionsQueryHandler(IQuestionRepository questionRepository)
    {
        this.questionRepository = questionRepository;
    }

    public async Task<ErrorOr<List<QuestionResult>>> Handle(
        GetAllQuestionsQuery query,
        CancellationToken cancellationToken
    )
    {
        List<Question> questions = new List<Question>();
        QueryParamsWithEssayFilters? filters = query.Filters;

        questions = await this.questionRepository.GetAll(filters, cancellationToken);

        List<QuestionResult> questionsResults = questions
            .Select(questions => new QuestionResult(
                questions.Id.Value,
                questions.EssayId,
                questions.Label,
                questions.Answer ?? string.Empty,
                questions.IsCompleted,
                questions.QuestionType,
                questions.DifficultyLevel,
                questions.CreatedDateTime,
                questions.UpdatedDateTime
            ))
            .ToList();

        return questionsResults;
    }
}
