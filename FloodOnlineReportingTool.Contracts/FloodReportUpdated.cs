namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// This message is used to communicate changes to the flood records between systems. 
/// Updating the record status and may optionally also be triggering an action requests.
/// </summary>
public record FloodReportUpdated
(
    Guid Id,
    string Reference,
    Uri ViewUri,
    DateTimeOffset UpdatedUtc,
    Guid RecordStatusUpdate,
    IReadOnlyCollection<ActionRequest> ActionStatusUpdates
);
