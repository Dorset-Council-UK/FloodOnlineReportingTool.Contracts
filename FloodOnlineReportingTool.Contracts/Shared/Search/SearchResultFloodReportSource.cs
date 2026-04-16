using NetTopologySuite.Geometries;

namespace FloodOnlineReportingTool.Contracts.Shared.Search;

/// <summary>
/// Represents the source record for a flood report in the search result. 
/// For example it might be a public report of flooding or a site visit from a professional partner.
/// </summary>
public record SearchResultFloodReportSource(
    Guid Id,
    string Reference,
    Uri ViewUri,
    DateTimeOffset CreatedUtc,
    DateTimeOffset? UpdatedUtc,
    Point Geom,
    double Easting,
    double Northing,
    decimal Latitude,
    decimal Longitude,
    DateTimeOffset? ImpactStartUtc,
    IReadOnlyCollection<SearchResultFloodReportCause> Causes,
    IReadOnlyCollection<SearchResultFloodReportOrganisation> Organisations) : ISearchResultFloodReportSource;