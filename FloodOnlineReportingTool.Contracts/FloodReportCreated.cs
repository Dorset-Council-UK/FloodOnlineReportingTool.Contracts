using FloodOnlineReportingTool.Contracts.Shared;

namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// Flood report created contract using an immutable record.
/// 
/// This is used to notify flood risk management modules that a new flood report has been created ready for review.
/// We only provide the reference / location required to search within the module and whether or not there are contacts.  
/// </summary>
public record FloodReportCreated(
    string Reference,
    double Easting,
    double Northing,
    bool HasContacts,
    IReadOnlyCollection<ContactRecordType> ContactRecordTypes
);
