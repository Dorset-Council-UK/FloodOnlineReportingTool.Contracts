namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Contract used to re-trigger email validation for a given contact record using an immutable record.
/// </summary>
/// <remarks>Use <see cref="VerifyContactTriggered"/> instead.</remarks>
[Obsolete($"Use {nameof(VerifyContactTriggered)} instead.", error: false)]
public record ConfirmationLinkSent(string ContactRecordId);
