using FloodOnlineReportingTool.Contracts.Shared;

namespace FloodOnlineReportingTool.Contracts;

/// <summary>
/// This record allows us to bind together an action with associated information (if required).
/// </summary>
/// <remarks>Use <see cref="FloodEventActionRequest"/> instead.</remarks>
[Obsolete($"Use {nameof(FloodEventActionRequest)} instead.", error: false)]
public record ActionRequest
(
    Guid ActionRequestId,
    IReadOnlyCollection<ContactRecordType> ContactRecordTypes,
    string? ActionRequestMessageId,
    string? ActionRequestMessage
);
