namespace FloodOnlineReportingTool.Contracts.Shared.Search;

/// <summary>
/// Represents a paginated result set specifically for Flood Reports, including the collection of results, 
/// a count of the total flood source records, and metadata about the pagination state.
/// </summary>
/// <remarks>This record is similar to PagedResult, but tweaked to include the total flood source count.</remarks>
public record SearchFloodReportPagedResult<T>(
    IReadOnlyCollection<T> Results,
    int TotalCount,
    int TotalFloodSourceCount,
    int PageSize,
    int CurrentPage,
    int TotalPages
) : PagedResult<T>(Results, TotalCount, PageSize, CurrentPage, TotalPages);