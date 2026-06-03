namespace FloodOnlineReportingTool.Contracts.Shared.Models;

public record FloodReportWithSourceReferences
{
    public required Guid Id { get; init; }
    public required string Reference { get; init; }
    public required Guid RecordStatus { get; init; }
    public required FloodReportType RecordType { get; init; }
    public DateTimeOffset CreatedUtc { get; init; }
    public DateTimeOffset? UpdatedUtc { get; init; }
    public double Easting { get; init; }
    public double Northing { get; init; }
    public decimal Latitude { get; init; }
    public decimal Longitude { get; init; }
    public IReadOnlyCollection<string> SourceReferences { get; init; } = [];
}
