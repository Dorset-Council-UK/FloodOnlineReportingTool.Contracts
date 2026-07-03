namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood event updated contract using an immutable record.
/// 
/// This is used to notify flood risk management modules that a flood event has been updated.
/// </summary>
public record FloodEventUpdated(
    Guid? Id,
    string Reference,
    string Title,
    Guid RecordStatus,
    Guid FloodStatus,
    Guid InvestigationStatus,
    DateTimeOffset FloodStartDate,
    DateTimeOffset FloodEndDate,
    IReadOnlyCollection<Guid>? FloodCauses,
    IReadOnlyCollection<Guid>? Organisations,
    IReadOnlyCollection<Guid>? StatusFilter,
    IReadOnlyCollection<Guid>? LinkedFloodReports
);
