namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Eligibility check updated contract using an immutable record.
/// </summary>
public record EligibilityCheckUpdated(
    Guid Id,
    DateTimeOffset UpdatedUtc,
    long? Uprn,
    long? Usrn,
    double Easting,
    double Northing,
    DateTimeOffset? ImpactStartUTC,
    int ImpactDurationHours,
    bool IsOnGoing,
    bool IsUninhabitable,
    int? VulnerableCount,
    IReadOnlyCollection<EligibilityCheckOrganisation> Organisations,
    IReadOnlyCollection<EligibilityCheckFloodSource> FloodSources
);


