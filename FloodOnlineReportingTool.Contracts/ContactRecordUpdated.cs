namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Contact record updated contract using an immutable record.
/// </summary>
public record ContactRecordUpdated(string FloodReportReference, Guid Id, string ContactType, DateTimeOffset UpdatedUtc);
