namespace FloodOnlineReportingTool.Contracts.Shared;

/// <summary>
/// The contact record type.
/// Helps ensure consistency and allows easier comparison across projects.
/// </summary>
public enum ContactRecordType
{
    Unknown = 0,
    Tenant,
    HomeOwner,
    NonResident,
}
