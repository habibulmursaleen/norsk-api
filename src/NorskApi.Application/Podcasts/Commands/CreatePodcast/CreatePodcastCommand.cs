using ErrorOr;
using MediatR;
using NorskApi.Application.Podcasts.Models;
using NorskApi.Domain.Common.Enums;

namespace NorskApi.Application.Podcasts.Commands.CreatePodcast;

public record CreatePodcastCommand(
    Guid? EssayId,
    string Label,
    string? Descriptions,
    string Logo,
    string Url,
    bool IsCompleted,
    bool IsFeatured,
    DifficultyLevel DifficultyLevel
) : IRequest<ErrorOr<PodcastResult>>;
