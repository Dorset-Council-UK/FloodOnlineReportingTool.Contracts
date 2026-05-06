namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood report source deleted contract using an immutable record.
/// </summary>
public record FloodReportSourceDeleted(Guid Id, string Reference);
