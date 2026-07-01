namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood Report Source Investigation triggered contract using an immutable record.
/// </summary>
public record FloodReportTriggerExtra(Guid Id, string Reference, DateTimeOffset TriggeredUtc);
