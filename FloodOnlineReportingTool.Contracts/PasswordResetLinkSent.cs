namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Password reset link sent contract using an immutable record.
/// </summary>
[Obsolete("PasswordResetLinkSent is no longer required as we are using identity providers.")]
public record PasswordResetLinkSent(string UserId, string EmailAddress, string ResetLink);
