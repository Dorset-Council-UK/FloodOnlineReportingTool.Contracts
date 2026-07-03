namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood event created contract using an immutable record.
/// 
/// This is used to notify flood risk management modules that a new flood event has been created ready for review. 
/// </summary>
public record FloodEventCreated(
    string Reference,
    string Title,
    Guid RecordStatus,
    Guid FloodStatus,
    Guid InvestigationStatus,
    DateTimeOffset FloodStartDate,
    DateTimeOffset FloodEndDate,
    IReadOnlyCollection<Guid> FloodCauses,
    IReadOnlyCollection<Guid> Organisations,
    IReadOnlyCollection<Guid> StatusFilter,
    IReadOnlyCollection<string> LinkedFloodReports
);
