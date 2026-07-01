
namespace FloodOnlineReportingTool.Contracts.Topics;

public static class TopicNames
{
    // Flood Report contracts
    public const string FloodReportCreated = "floodreport-created";
    public const string FloodReportUpdated = "floodreport-updated";
    public const string FloodReportDeleted = "floodreport-deleted";
    public const string FloodReportExtraInfoRequest = "floodreport-extra-info-request";

    // Flood Report Source contracts
    public const string FloodReportSourceCreated = "floodreport-source-created";
    public const string FloodReportSourceUpdated = "floodreport-source-updated";
    public const string FloodReportSourceDeleted = "floodreport-source-deleted";
    public const string FloodReportSourceVerifyContact = "floodreport-source-verify-contact";

    // Flood Event contracts
    public const string FloodEventCreated = "floodevent-created";
    public const string FloodEventUpdated = "floodevent-updated";
    public const string FloodEventActionRequest = "floodevent-action-request";
    public const string FloodEventS19Completed = "floodevent-s19-completed";
    public const string FloodEventS19Triggered = "floodevent-s19-triggered";
}
