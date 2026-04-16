
namespace FloodOnlineReportingTool.Contracts.Topics;

public static class TopicNames
{
    public const string FloodSourceCreated = "floodreport.status-createreport";
    public const string FloodSourceUpdated = "floodreport.status-updatereport";
    public const string FloodSourceDeleted = "floodreport.status-deletereport";
    public const string InvestigationCreated = "floodreport.status-createinvestigation";
    public const string FloodReportCreated = "floodreport.management-createreport";
    public const string FloodReportUpdated = "floodreport.management-updatereport";
    public const string FloodReportDeleted = "floodreport.management-deletereport";
    public const string InvestigationTriggered = "floodreport.management-trigger.investigation";
    public const string PasswordResetTriggered = "floodreport.management-trigger.passwordreset";
}
