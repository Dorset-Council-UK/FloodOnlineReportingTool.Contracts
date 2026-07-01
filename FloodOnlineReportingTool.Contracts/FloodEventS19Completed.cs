namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// TODO : This contract doesn't seem to be what it should be. This should be a message to indicate that a flood event section 19 report has been completed, but it contains a lot of properties that are not relevant to the flood event itself.
/// </summary>
public record FloodEventS19Completed
{
    public required string FloodReportReference { get; init; }
    public required Guid Id { get; init; }
    public required DateTimeOffset CreatedUtc { get; init; }
    public required bool HasEntries { get; init; }
    public required bool HasHistory { get; init; }
    public required bool HasPropertyInsurance { get; init; }
    public required bool HasPeakDepth { get; init; }
    public required bool HasInternalFlooding { get; init; }
    public required bool HasDestination { get; init; }
    public required bool HasDamagedVehicles { get; init; }
    public required bool HasImpactedServices { get; init; }
    public required bool HasImpactedTheCommunity { get; init; }
    public required bool HasBlockages { get; init; }
    public required bool ActionsWereTaken { get; init; }
    public required bool HelpWasReceived { get; init; }
    public required bool RegisteredWithFloodline { get; init; }
    public bool ReceivedFloodlineWarningInTime { get; init; }
    public required bool ReceivedOtherWarnings { get; init; }
}