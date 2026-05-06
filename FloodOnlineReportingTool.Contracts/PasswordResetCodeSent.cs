namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Password reset code sent contract using an immutable record.
/// </summary>
[Obsolete("PasswordResetCodeSent is no longer required as we are using identity providers.")]
public record PasswordResetCodeSent(string UserId, string EmailAddress, string ResetCode);
