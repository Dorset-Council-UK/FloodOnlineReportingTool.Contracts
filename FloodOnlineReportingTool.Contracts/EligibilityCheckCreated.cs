namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Eligibility check created contract using an immutable record.
/// </summary>
public record EligibilityCheckCreated(
    Guid Id,
    string FloodReportReference,
    DateTimeOffset CreatedUtc,
    long? Uprn,
    long? Usrn,
    double Easting,
    double Northing,
    DateTimeOffset? ImpactStartUTC,
    int ImpactDurationHours,
    bool IsOnGoing,
    bool IsUninhabitable,
    int? VulnerableCount,
    string? LocationDescription,
    IReadOnlyCollection<EligibilityCheckOrganisation> Organisations,
    IReadOnlyCollection<EligibilityCheckFloodSource> FloodSources
);
