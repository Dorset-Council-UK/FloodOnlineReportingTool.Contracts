using FloodOnlineReportingTool.Contracts.Shared;
using FloodOnlineReportingTool.Contracts.Shared.Models;

namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood report source created contract using an immutable record.
/// 
/// We are making an assumption that the system managing the flood reports is responsible for notifying the contacts.
/// However, we need to know if contacts exist and what types they are so we can notify linked systems:
///  - whether a request can be made
///  - what type of person may receive the request (tenant, home owner, non-resident)
///  
/// The initial eligibility check information is also included to allow the report status module to log shared data.
/// The ViewUri is used as the pointer back to the original source.
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
