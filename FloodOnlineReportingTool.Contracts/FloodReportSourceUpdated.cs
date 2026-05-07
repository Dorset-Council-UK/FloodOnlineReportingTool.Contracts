using FloodOnlineReportingTool.Contracts.Shared.Models;

namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// This message is used to communicate changes to the flood source records between systems. 
/// Updating the record status and may optionally also be triggering an action requests.
/// </summary>
public record FloodReportSourceUpdated
(
    Guid Id,
    string Reference,
    Uri ViewUri,
    DateTimeOffset UpdatedUtc,
    Guid RecordStatusUpdate,
    EligibilityCheckRecord? EligibilityCheckRecord,
    IReadOnlyCollection<ActionRequest> ActionStatusUpdates
);
