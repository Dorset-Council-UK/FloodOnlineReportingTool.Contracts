namespace FloodOnlineReportingTool.Contracts;

public record EligibilityCheckFloodSource(
    Guid Id,
    string Name, // Not required, but useful for display
    Guid FloodSourceId,
    string FloodSourceName // Not required, but useful for display
);
