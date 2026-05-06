namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Contract used to re-trigger email validation for a given contact record using an immutable record.
/// </summary>
public record ContactValidationTriggered(string ContactRecordId);
