namespace FloodOnlineReportingTool.Contracts.Shared.Search;

/// <summary>
/// Represents a paginated result set, including the collection of results and metadata about the pagination state.
/// </summary>
/// <remarks>This record is commonly used to encapsulate the results of a paginated query, providing both the data
/// and information about the pagination, such as the current page and total number of pages.</remarks>
/// <typeparam name="T">The type of the items in the result set.</typeparam>
public record PagedResult<T>(
    IReadOnlyCollection<T> Results,
    int TotalCount,
    int PageSize,
    int CurrentPage,
    int TotalPages
);