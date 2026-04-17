namespace FloodOnlineReportingTool.Contracts.Shared.Search;

/// <summary>
/// Represents the organisation associated with a flood report in a search result. 
/// Examples include local authorities, emergency services, and other relevant organisations.
/// </summary>
/// <param name="OrgId">The unique identifier of the organisation.</param>
/// <param name="OrgName">A helpful name or description of the organisation.</param>
/// <param name="FloodAuthorityId">The unique identifier of the flood authority associated with the organisation.</param>
/// <param name="FloodAuthorityName">The name of the flood authority associated with the organisation.</param>
public record SearchResultFloodReportOrganisation(Guid OrgId, string OrgName, Guid FloodAuthorityId, string FloodAuthorityName);