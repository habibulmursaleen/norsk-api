using NorskApi.Application.Common.Interfaces.Persistance.IQueryParamsBuilders;
using NorskApi.Application.Common.QueryParamsBuilder;
using NorskApi.Domain.Common.Enums;
using NorskApi.Infrastructure.Persistance.DBContext;

namespace NorskApi.Infrastructure.Common;

public class QueryParamsBaseBuilder : IQueryParamsBaseBuilder
{
    private readonly NorskApiDbContext dbContext;

    public QueryParamsBaseBuilder(NorskApiDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public IQueryable<T>? BuildQueriesGrammarTopics<T>(QueryParamsBaseFilters filters)
    {
        var query = dbContext.GrammarTopics.AsQueryable();
        double skip =
            (filters.Page > 0 && filters.Size > 0) ? (filters.Page - 1) * (int)filters.Size : 0;
        double take = filters.Size > 0 ? (int)filters.Size : 25;

        if (
            filters.DifficultyLevel != default
            || filters.DifficultyLevel != DifficultyLevel.ALL
                && Enum.IsDefined(typeof(DifficultyLevel), filters.DifficultyLevel)
        )
        {
            query = query.Where(x => x.DifficultyLevel == filters.DifficultyLevel);
        }
        if (!string.IsNullOrEmpty(filters.SortBy))
        {
            switch (filters.SortBy.ToLower())
            {
                case "asc":
                    query = query.OrderBy(x => x.CreatedDateTime);
                    break;
                case "desc":
                    query = query.OrderByDescending(x => x.CreatedDateTime);
                    break;
                default:
                    query = query.OrderBy(x => x.CreatedDateTime);
                    break;
            }
        }

        return (IQueryable<T>?)query;
    }

    public IQueryable<T>? BuildQueriesEssays<T>(QueryParamsBaseFilters filters)
    {
        var query = dbContext.Essays.AsQueryable();
        double skip =
            (filters.Page > 0 && filters.Size > 0) ? (filters.Page - 1) * (int)filters.Size : 0;
        double take = filters.Size > 0 ? (int)filters.Size : 25;

        if (
            filters.DifficultyLevel != default
            || filters.DifficultyLevel != DifficultyLevel.ALL
                && Enum.IsDefined(typeof(DifficultyLevel), filters.DifficultyLevel)
        )
        {
            query = query.Where(x => x.DifficultyLevel == filters.DifficultyLevel);
        }
        if (!string.IsNullOrEmpty(filters.SortBy))
        {
            switch (filters.SortBy.ToLower())
            {
                case "asc":
                    query = query.OrderBy(x => x.CreatedDateTime);
                    break;
                case "desc":
                    query = query.OrderByDescending(x => x.CreatedDateTime);
                    break;
                default:
                    query = query.OrderBy(x => x.CreatedDateTime);
                    break;
            }
        }

        return (IQueryable<T>?)query;
    }

    public IQueryable<T>? BuildQueriesGrammarRules<T>(QueryParamsBaseFilters filters)
    {
        var query = dbContext.GrammarRules.AsQueryable();
        double skip =
            (filters.Page > 0 && filters.Size > 0) ? (filters.Page - 1) * (int)filters.Size : 0;
        double take = filters.Size > 0 ? (int)filters.Size : 25;

        if (
            filters.DifficultyLevel != default
            || filters.DifficultyLevel != DifficultyLevel.ALL
                && Enum.IsDefined(typeof(DifficultyLevel), filters.DifficultyLevel)
        )
        {
            query = query.Where(x => x.DifficultyLevel == filters.DifficultyLevel);
        }

        if (!string.IsNullOrEmpty(filters.SortBy))
        {
            switch (filters.SortBy.ToLower())
            {
                case "asc":
                    query = query.OrderBy(x => x.CreatedDateTime);
                    break;
                case "desc":
                    query = query.OrderByDescending(x => x.CreatedDateTime);
                    break;
                default:
                    query = query.OrderBy(x => x.CreatedDateTime);
                    break;
            }
        }

        return (IQueryable<T>?)query;
    }

    public IQueryable<T>? BuildQueriesNorskproves<T>(QueryParamsBaseFilters filters)
    {
        var query = dbContext.Norskproves.AsQueryable();
        double skip =
            (filters.Page > 0 && filters.Size > 0) ? (filters.Page - 1) * (int)filters.Size : 0;
        double take = filters.Size > 0 ? (int)filters.Size : 25;

        if (
            filters.DifficultyLevel != default
            || filters.DifficultyLevel != DifficultyLevel.ALL
                && Enum.IsDefined(typeof(DifficultyLevel), filters.DifficultyLevel)
        )
        {
            query = query.Where(x => x.DifficultyLevel == filters.DifficultyLevel);
        }

        if (!string.IsNullOrEmpty(filters.SortBy))
        {
            switch (filters.SortBy.ToLower())
            {
                case "asc":
                    query = query.OrderBy(x => x.CreatedDateTime);
                    break;
                case "desc":
                    query = query.OrderByDescending(x => x.CreatedDateTime);
                    break;
                default:
                    query = query.OrderBy(x => x.CreatedDateTime);
                    break;
            }
        }

        return (IQueryable<T>?)query;
    }
}
