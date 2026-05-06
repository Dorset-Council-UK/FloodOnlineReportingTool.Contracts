namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Password reset triggered contract using an immutable record.
/// </summary>
public record PasswordResetTriggered(string UserId, DateTimeOffset TriggeredUtc);