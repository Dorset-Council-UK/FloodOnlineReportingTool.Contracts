using NetTopologySuite.Geometries;

namespace FloodOnlineReportingTool.Contracts.Shared.Search;

/// <summary>
/// Represents a search result for a flood location
/// </summary>
public record SearchResultFloodLocation(
    Guid Id,
    DateTimeOffset CreatedUtc,
    DateTimeOffset? UpdatedUtc,
    string Title,
    Point Location,
    IReadOnlyCollection<SearchResultFloodLocationFloodReport> FloodReports
);