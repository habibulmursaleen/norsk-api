using NorskApi.Domain.Common.Models;

namespace NorskApi.Domain.PodcastAggregate.Events.DomainEvent
{
    public record PodcastUpdatedDomainEvent(Podcast Podcast) : IDomainEvent;
}

