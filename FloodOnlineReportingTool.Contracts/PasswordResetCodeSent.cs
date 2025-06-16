namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Password reset code sent, contract using an immutable record.
/// </summary>
public record PasswordResetCodeSent(string UserId, string EmailAddress, string ResetCode);
