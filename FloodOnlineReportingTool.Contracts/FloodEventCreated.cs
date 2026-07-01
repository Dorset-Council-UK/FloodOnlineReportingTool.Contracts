namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood event created contract using an immutable record.
/// 
/// This is used to notify flood risk management modules that a new flood event has been created ready for review.
/// We only provide the reference / location required to search within the module and whether or not there are linked flood reports.  
/// </summary>
public record FloodEventCreated(
    Guid Id,
    string Reference,
    string Title,
    DateTimeOffset CreatedUtc,
    bool HasSection19Report,
    IReadOnlyCollection<Guid> LinkedFloodReports
);
