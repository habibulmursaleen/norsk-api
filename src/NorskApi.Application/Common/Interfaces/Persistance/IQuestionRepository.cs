using NorskApi.Application.Common.QueryParamsBuilder;
using NorskApi.Domain.EssayAggregate.ValueObjects;
using NorskApi.Domain.QuestionAggregate;
using NorskApi.Domain.QuestionAggregate.ValueObjects;

namespace NorskApi.Application.Common.Interfaces.Persistance;

public interface IQuestionRepository
{
    Task<List<Question>> GetAll(
        QueryParamsBaseFilters? filters,
        CancellationToken cancellationToken
    );
    Task<List<Question>> GetAllByEssayId(
        EssayId essayId,
        QueryParamsBaseFilters filters,
        CancellationToken cancellationToken
    );
    Task<Question?> GetById(
        EssayId essayId,
        QuestionId questionId,
        CancellationToken cancellationToken
    );
    Task Add(Question questionId, CancellationToken cancellationToken);
    Task Update(Question questionId, CancellationToken cancellationToken);
    Task Delete(Question questionId, CancellationToken cancellationToken);
}