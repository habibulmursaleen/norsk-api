namespace NorskApi.Domain.Common.Errors;

using ErrorOr;

public static partial class Errors
{
    public static class DiscussionErrors
    {
        public static Error DiscussionNotFound(Guid DiscussionId, Guid EssayId) =>
            Error.NotFound(
                code: "404",
                description: $"Discussion with id {DiscussionId} or essayId {EssayId} not found."
            );
    }
}
