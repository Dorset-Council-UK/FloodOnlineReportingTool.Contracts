namespace FloodOnlineReportingTool.Contracts.Shared.Search;

/// <summary>
/// Represents the source of a flood report in a search result.
/// </summary>
/// <param name="SourceId">The unique identifier of the flood report source.</param>
/// <param name="Name">A helpful name or description of the flood report source.</param>
public record SearchResultFloodReportSource(Guid SourceId, string Name);