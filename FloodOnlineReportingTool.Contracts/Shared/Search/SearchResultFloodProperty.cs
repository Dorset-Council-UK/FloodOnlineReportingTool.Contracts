using NetTopologySuite.Geometries;

namespace FloodOnlineReportingTool.Contracts.Shared.Search;

/// <summary>
/// Represents a search result for a flood property
/// </summary>
public record SearchResultFloodProperty(
    Guid Id,
    DateTimeOffset CreatedUtc,
    DateTimeOffset? UpdatedUtc,
    string Title,
    string Uprn,
    Point Geom,
    IReadOnlyCollection<SearchResultFloodPropertyFloodReport> FloodReports
);