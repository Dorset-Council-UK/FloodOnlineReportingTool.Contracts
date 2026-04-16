using NetTopologySuite.Geometries;

namespace FloodOnlineReportingTool.Contracts.Shared.Search;

public interface ISearchResultFloodReportSource
{
    Guid Id { get; }
    string Reference { get; }
    Uri ViewUri { get; }
    DateTimeOffset CreatedUtc { get; }
    DateTimeOffset? UpdatedUtc { get; }
    Point Geom { get; }
    double Easting { get; }
    double Northing { get; }
    DateTimeOffset? ImpactStartUtc { get; }
    IReadOnlyCollection<SearchResultFloodReportCause> Causes { get; }
    IReadOnlyCollection<SearchResultFloodReportOrganisation> Organisations { get; }
}