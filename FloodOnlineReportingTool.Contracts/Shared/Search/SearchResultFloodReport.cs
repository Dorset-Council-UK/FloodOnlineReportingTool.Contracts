namespace FloodOnlineReportingTool.Contracts.Shared.Search;

/// <summary>
/// Represents a flood report search result, including its reference, status, and associated source records.
/// </summary>
/// <param name="RecordStatusId">The unique identifier of the record status.</param>
public record SearchResultFloodReport(
   Guid Id,
   string Reference,
   Guid RecordStatusId,
   IReadOnlyCollection<SearchResultFloodReportSource> SourceRecords
);