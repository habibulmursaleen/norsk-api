using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NorskApi.Domain.ActivityAggregate;
using NorskApi.Domain.Common.Models;
using NorskApi.Domain.DictationAggregate;
using NorskApi.Domain.DiscussionAggregate;
using NorskApi.Domain.GrammarTopicAggregate;
using NorskApi.Domain.GrammmarRuleAggregate;
using NorskApi.Domain.LocalExpressionAggregate;
using NorskApi.Domain.NorskproveAggregate;
using NorskApi.Domain.PodcastAggregate;
using NorskApi.Domain.QuestionAggregate;
using NorskApi.Domain.QuizAggregate;
using NorskApi.Domain.SubjunctionAggregate;
using NorskApi.Domain.TagAggregate;
using NorskApi.Domain.TaskWorkAggregate;
using NorskApi.Domain.WordAggregate;
using NorskApi.Infrastructure.Persistance.Interceptors;

namespace NorskApi.Infrastructure.Persistance.DBContext;

public sealed class NorskApiDbContext : DbContext
{
    private readonly PublishDomainEventsInterceptor publishDomainEventsInterceptor;
    private readonly string connectionString;

    public DbSet<LocalExpression> LocalExpressions { get; set; } = null!;
    public DbSet<Discussion> Discussions { get; set; } = null!;
    public DbSet<Dictation> Dictations { get; set; } = null!;
    public DbSet<Podcast> Podcasts { get; set; } = null!;
    public DbSet<Question> Questions { get; set; } = null!;
    public DbSet<TaskWork> TaskWorks { get; set; } = null!;
    public DbSet<GrammarTopic> GrammarTopics { get; set; } = null!;
    public DbSet<Quiz> Quizes { get; set; } = null!;
    public DbSet<Essay> Essays { get; set; } = null!;
    public DbSet<GrammarRule> GrammarRules { get; set; } = null!;
    public DbSet<Subjunction> Subjunctions { get; set; } = null!;
    public DbSet<Word> Words { get; set; } = null!;
    public DbSet<Tag> Tags { get; set; } = null!;
    public DbSet<Norskprove> Norskproves { get; set; } = null!;
    public DbSet<Activity> Activities { get; set; } = null!;

    public NorskApiDbContext(
        DbContextOptions<NorskApiDbContext> options,
        PublishDomainEventsInterceptor publishDomainEventsInterceptor,
        IConfiguration configuration
    )
        : base(options)
    {
        this.publishDomainEventsInterceptor = publishDomainEventsInterceptor;
        this.connectionString =
            configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException(
                "Connection string 'DefaultConnection' not found."
            );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Ignore<List<IDomainEvent>>()
            .ApplyConfigurationsFromAssembly(typeof(NorskApiDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
                .UseSqlServer(connectionString, b => b.MigrationsAssembly("NorskApi.Api"))
                .AddInterceptors(publishDomainEventsInterceptor);
        }
    }

    public override Task<int> SaveChangesAsync(
        CancellationToken cancellationToken = default(CancellationToken)
    )
    {
        this.SetTimestamps();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void SetTimestamps()
    {
        var entries = ChangeTracker
            .Entries()
            .Where(e =>
                e.Entity is IHasTimeStamp
                && (e.State == EntityState.Added || e.State == EntityState.Modified)
            );

        foreach (var entityEntry in entries)
        {
            var entity = (IHasTimeStamp)entityEntry.Entity;

            if (entityEntry.State == EntityState.Added)
            {
                entity.CreatedDateTime = DateTime.UtcNow;
            }
            entity.UpdatedDateTime = DateTime.UtcNow;
        }
    }
}
