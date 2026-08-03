namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Contract used to re-trigger email validation for a given contact subscription record using an immutable record.
/// </summary>
public record FloodReportSourceVerifyContact(Guid SubscribeRecordId);
