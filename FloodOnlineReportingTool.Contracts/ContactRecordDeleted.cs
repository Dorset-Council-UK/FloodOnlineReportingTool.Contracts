namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Contact record deleted contract using an immutable record.
/// </summary>
public record ContactRecordDeleted(string FloodReportReference, Guid Id, string ContactType, DateTimeOffset DeletedUtc);
