using NorskApi.Domain.Common.Models;
using NorskApi.Domain.SubjunctionAgreegate;

namespace NorskApi.Domain.SubjunctionAggregate.Events.DomainEvent
{
    public record SubjunctionCreatedDomainEvent(Subjunction Subjunction) : IDomainEvent;
}

