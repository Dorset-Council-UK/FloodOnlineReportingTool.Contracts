namespace FloodOnlineReportingTool.Contracts.Shared.Search;

/// <summary>
/// Represents the source/cause of a flood in a search result. 
/// Examples include River, Surface Water, Groundwater, Sewer, Coastal, etc.
/// </summary>
/// <param name="CauseId">The unique identifier of the flood cause.</param>
/// <param name="Name">A helpful name or description of the flood cause.</param>
public record SearchResultFloodReportCause(Guid CauseId, string Name);