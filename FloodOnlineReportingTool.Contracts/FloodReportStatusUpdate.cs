namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// This message is used to communicate changes to the flood records between systems. 
/// It updating the record status and may optionally also be triggering an action requests.
/// </summary>
public record FloodReportUpdated
(
    Guid Id,
    string Reference,
    DateTimeOffset UpdatedUtc,
    Guid RecordStatusUpdate,
    IReadOnlyCollection<ActionRequest> ActionStatusUpdates
);
