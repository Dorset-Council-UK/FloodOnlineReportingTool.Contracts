namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood event created contract using an immutable record.
/// 
/// This is used to notify flood risk management modules that a new flood event has been created ready for review.
/// We only provide the reference / location required to search within the module and whether or not there are linked flood reports.  
/// </summary>
public record FloodEventCreated(
    string Reference,
    string Title,
    Guid RecordStatus,
    Guid FloodStatus,
    Guid InvestigationStatus,
    DateTimeOffset FloodStartDate,
    DateTimeOffset FloodEndDate,
    bool HasSection19Report,
    IReadOnlyCollection<Guid> FloodCauses,
    IReadOnlyCollection<Guid> Organisations,
    IReadOnlyCollection<Guid> StatusFilter,
    IReadOnlyCollection<Guid> LinkedFloodReports
);
