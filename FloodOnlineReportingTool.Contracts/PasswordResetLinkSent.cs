namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Password reset link sent, contract using an immutable record.
/// </summary>
public record PasswordResetLinkSent(string UserId, string EmailAddress, string ResetLink);
