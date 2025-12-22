namespace FloodOnlineReportingTool.Contracts.Shared.Search;

/// <summary>
/// Represents a search result for a flood report related to a flood road
/// </summary>
public record SearchResultFloodRoadFloodReport(
    Guid FloodReportId,
    DateTimeOffset CreatedUtc,
    DateTimeOffset? UpdatedUtc,
    DateTimeOffset? ConfirmedUtc,
    string? ConfirmedUserName
);