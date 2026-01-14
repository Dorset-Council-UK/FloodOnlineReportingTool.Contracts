using NetTopologySuite.Geometries;

namespace FloodOnlineReportingTool.Contracts.Shared.Search;

/// <summary>
/// Represents a search result for a flood road
/// </summary>
public record SearchResultFloodRoad(
    Guid Id,
    DateTimeOffset CreatedUtc,
    DateTimeOffset? UpdatedUtc,
    string Title,
    long Usrn,
    Point Geom,
    decimal Latitude,
    decimal Longitude,
    IReadOnlyCollection<SearchResultFloodRoadFloodReport> FloodReports
);