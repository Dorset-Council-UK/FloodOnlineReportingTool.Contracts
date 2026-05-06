namespace FloodOnlineReportingTool.Contracts;

public record EligibilityCheckOrganisation(
    Guid Id,
    string Name, // Not required, but useful for display
    Guid FloodAuthorityId,
    string FloodAuthorityName // Not required, but useful for display
);
