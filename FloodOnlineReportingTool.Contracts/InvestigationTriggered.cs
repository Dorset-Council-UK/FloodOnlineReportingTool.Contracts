namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Investigation triggered contract using an immutable record.
/// </summary>
/// <remarks>Use <see cref="FloodEventS19Triggered"/> instead.</remarks>
[Obsolete($"Use {nameof(FloodEventS19Triggered)} instead.", error: false)]
public record InvestigationTriggered(Guid Id, string Reference, DateTimeOffset TriggeredUtc);
