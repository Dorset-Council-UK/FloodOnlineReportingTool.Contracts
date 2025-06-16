namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Confirmation link sent, contract using an immutable record.
/// </summary>
public record ConfirmationLinkSent(string UserId, string EmailAddress, string ConfirmationLink);
