namespace FloodOnlineReportingTool.Contracts.Shared.Search;

public record SearchResultFloodReport(
    Guid Id,
    DateTimeOffset CreatedUtc,
    DateTimeOffset? UpdatedUtc,
    double Easting,
    double Northing,
    DateTimeOffset? ImpactStartUtc,
    IReadOnlyCollection<SearchResultFloodReportSource> Sources
);