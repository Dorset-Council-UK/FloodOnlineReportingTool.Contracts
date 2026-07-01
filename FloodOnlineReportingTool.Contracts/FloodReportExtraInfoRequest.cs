namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood Report contract to trigger request for extra info using an immutable record.
/// </summary>
public record FloodReportExtraInfoRequest(Guid Id, string Reference, DateTimeOffset TriggeredUtc);
