namespace FloodOnlineReportingTool.Contracts.Shared.Search;

/// <summary>
/// Represents a search result for a flood report, including its unique identifier, creation and update timestamps,
/// data sources.
/// </summary>
/// <param name="RecordStatusId">Is a GUID representing a RecordStatusIds</param>
public record SearchResultFloodReport(
   Guid Id,
   string Reference,
   Guid RecordStatusId,
   IReadOnlyCollection<SearchResultFloodReportSource> SourceRecords
);