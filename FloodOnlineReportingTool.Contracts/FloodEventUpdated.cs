namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood event updated contract using an immutable record.
/// 
/// This is used to notify flood risk management modules that a flood event has been updated.
/// </summary>
public record FloodEventUpdated(
    Guid Id,
    string Title,
    DateTimeOffset UpdatedUtc,
    bool HasSection19Report,
    IReadOnlyCollection<Guid> LinkedFloodReports
);
