namespace FloodOnlineReportingTool.Contracts.Shared.Search;

public record PagedResult<T>(
    IReadOnlyCollection<T> Results,
    int TotalCount,
    int PageSize,
    int CurrentPage,
    int TotalPages
);