namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood Report trigger contract using an immutable record.
/// </summary>
public record FloodReportTriggerExtra(Guid Id, string Reference, DateTimeOffset TriggeredUtc);
