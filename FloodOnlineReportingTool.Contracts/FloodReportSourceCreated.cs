using FloodOnlineReportingTool.Contracts.Shared;

namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood report created contract using an immutable record.
/// 
/// We are making an assumption that the system managing the flood reports is responsible for notifying the contacts.
/// However, we need to know if contacts exist and what types they are so we can notify linked systems:
///  - whether a request can be made
///  - what type of person may receive the request (tenant, home owner, non-resident)
/// </summary>
public record FloodReportSourceCreated(
    Guid Id,
    double Buffer,
    string Reference,
    Uri ViewUri,
    DateTimeOffset CreatedUtc,
    EligibilityCheckRecord EligibilityCheckRecord,
    bool HasInvestigation,
    bool HasContacts,
    IReadOnlyCollection<ContactRecordType> ContactRecordTypes
);
