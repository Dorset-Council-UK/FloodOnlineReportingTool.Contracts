namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood report created contract using an immutable record.
/// </summary>
public record FloodReportCreated(
    Guid Id,
    string Reference,
    DateTimeOffset CreatedUtc,
    bool HasEligibilityCheck,
    bool HasInvestigation,
    int NumberOfContactRecords
);
