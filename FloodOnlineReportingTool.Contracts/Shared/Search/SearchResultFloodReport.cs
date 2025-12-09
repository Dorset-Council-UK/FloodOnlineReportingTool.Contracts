using NetTopologySuite.Geometries;

namespace FloodOnlineReportingTool.Contracts.Shared.Search;

/// <summary>
/// Represents a search result for a flood report, including its unique identifier, creation and update timestamps,
/// data sources.
/// </summary>
public record SearchResultFloodReport(
    Guid Id,
    DateTimeOffset CreatedUtc,
    DateTimeOffset? UpdatedUtc,
    Point Location,
    DateTimeOffset? ImpactStartUtc,
    IReadOnlyCollection<SearchResultFloodReportSource> Sources
);