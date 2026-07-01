namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Investigation triggered contract using an immutable record.
/// </summary>
public record FloodEventS19Triggered(Guid Id, string Reference, DateTimeOffset TriggeredUtc);
