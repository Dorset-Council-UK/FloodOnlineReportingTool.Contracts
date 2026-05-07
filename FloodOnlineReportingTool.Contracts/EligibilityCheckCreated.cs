using FloodOnlineReportingTool.Contracts.Shared.Models;

namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Eligibility check created contract using an immutable record.
/// </summary>
/// <remarks>Use <see cref="FloodReportSourceCreated"/> instead.</remarks>
[Obsolete($"Use {nameof(FloodReportSourceCreated)} instead.", error: false)]
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