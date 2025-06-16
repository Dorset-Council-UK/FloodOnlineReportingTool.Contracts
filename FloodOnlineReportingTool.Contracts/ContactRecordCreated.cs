namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Contact record created contract using an immutable record.
/// </summary>
public record ContactRecordCreated(string FloodReportReference, Guid Id, string ContactType, DateTimeOffset CreatedUtc);
