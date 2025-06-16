namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Contact record created contract using an immutable record.
/// </summary>
public record InvestigationCreated
{
    public required string FloodReportReference { get; init; }
    public required Guid Id { get; init; }
    public required DateTimeOffset CreatedUtc { get; init; }
    public required bool HasEntries { get; init; }
    public required bool HasHistory { get; init; }
    public required bool HasPeakDepth { get; init; }
    public required bool HasInternalFlooding { get; init; }
    public required bool HasDestination { get; init; }
    public required bool HasDamagedVehicles { get; init; }
    public required bool HasImpactedTheCommunity { get; init; }
    public required bool HasBlockages { get; init; }
    public required bool ActionsWereTaken { get; init; }
    public required bool HelpWasReceived { get; init; }
    public required bool RegisteredWithFloodline { get; init; }
    public bool ReceivedFloodlineWarningInTime { get; init; }
    public required bool ReceivedOtherWarnings { get; init; }
}