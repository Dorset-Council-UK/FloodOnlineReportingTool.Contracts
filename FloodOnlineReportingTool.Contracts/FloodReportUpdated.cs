using FloodOnlineReportingTool.Contracts.Shared;

namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood report updated contract using an immutable record.
/// 
/// This is used to notify flood risk management modules that a flood report has been updated.
/// We provide the updated status so the module can generate suitable actions.
/// </summary>
public record FloodReportUpdated(
    Guid Id,
    string Reference,
    DateTimeOffset UpdatedUtc,
    Guid UpdatedStatus, // Suitable RecordStatusIds
    bool HasInvestigation,
    bool HasContacts,
    IReadOnlyCollection<ContactRecordType> ContactRecordTypes
);
