namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Investigation triggered contract using an immutable record.
/// </summary>
public record InvestigationTriggered(Guid Id, string Reference, DateTimeOffset TriggeredDate);
