using FloodOnlineReportingTool.Contracts.Shared;

namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// This record allows us to bind together an action with associated information (if required).
/// </summary>
/// <param name="ActionRequestId">
/// Requred, there must be an action type
/// </param>
/// 
/// <param name="ContactRecordTypes">
/// Optional, this is a list of assoicated contact types.
/// Example would be that the action type is notification sent. 
/// The included types would represent those notified successfully (i.e. sent to Owner and non resident)
/// A separate ActionLog may also be included in the update message which stats that the message to the tenant failed
/// </param>
/// 
/// TODO - work out the bits below, should this be parameters designed for triggering Gov.Notify messages or generic?
/// <param name="ActionRequestMessageId">
/// Optional, use this to send a predefined message template identifier. This would likely be a Gov.Notify template Id.
/// </param>
/// 
/// <param name="ActionRequestMessage">
/// Optional, if you are requesting a reply you may want to include a message to be sent.
/// </param>
public record ActionRequest
(
    Guid ActionRequestId,
    IReadOnlyCollection<ContactRecordType> ContactRecordTypes,
    string? ActionRequestMessageId,
    string? ActionRequestMessage
);
