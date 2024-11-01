using NorskApi.Domain.DiscussionAggregate;
using NorskApi.Domain.DiscussionAggregate.ValueObjects;
using NorskApi.Domain.EssayAggregate.ValueObjects;

namespace NorskApi.Application.Common.Interfaces.Persistance;

public interface IDiscussionRepository
{
    Task<List<Discussion>> GetAll(CancellationToken cancellationToken);
    Task<List<Discussion>> GetAllByEssayId(EssayId essayId, CancellationToken cancellationToken);
    Task<Discussion?> GetById(
        EssayId essayId,
        DiscussionId discussionId,
        CancellationToken cancellationToken
    );
    Task Add(Discussion discussionId, CancellationToken cancellationToken);
    Task Update(Discussion discussionId, CancellationToken cancellationToken);
    Task Delete(Discussion discussionId, CancellationToken cancellationToken);
}