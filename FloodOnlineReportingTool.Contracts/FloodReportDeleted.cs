namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood report deleted contract using an immutable record.
/// </summary>
public record FloodReportDeleted(Guid Id, string Reference);
