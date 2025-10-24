using FloodOnlineReportingTool.Contracts.Shared;

namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood report created contract using an immutable record.
/// 
/// We are making an assumption that the system managing the flood reports is responsible for notifyng the contacts.
/// However, we need to know if contacts exist and what types they are so we can notify linked systems whether:
///  - a request can be made
///  - what type of person may recieive the request (tenant, owner, non-resident)
/// </summary>
public record FloodReportCreated(
    Guid Id,
    string Reference,
    DateTimeOffset CreatedUtc,
    bool HasEligibilityCheck,
    bool HasInvestigation,
    bool HasContacts,
    IReadOnlyCollection<ContactRecordType> ContactRecordTypes
);
