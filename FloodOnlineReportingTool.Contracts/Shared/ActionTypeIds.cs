using System.Collections.Immutable;

namespace FloodOnlineReportingTool.Contracts.Shared;
public static class ActionTypeIds
{
    /// <summary>
    /// These actions are requests to another system to request a person performs an action.
    /// </summary>
    public readonly static Guid RequestInvestiagtion = new("a1b2c3d4-5e6f-4789-8abc-1234567890ab");
    public readonly static Guid RequestReply = new("b2c3d4e5-6f70-489a-9bcd-2345678901bc");
    public readonly static Guid RequestDataProtectionReview = new("c3d4e5f6-7081-49ab-acde-3456789012cd");

    /// <summary>
    /// These actions are requests to another system to perform an action.
    /// </summary>
    public readonly static Guid TriggerSection19 = new("d4e5f6a7-8192-4abc-bdef-4567890123de");
    public readonly static Guid TriggerRecordLock = new("e5f6a7b8-92a3-4bcd-cdef-5678901234ef");
    public readonly static Guid TriggerReplyReceived = new("f6a7b8c9-a3b4-4cde-def0-6789012345f0");

    /// <summary>
    /// These actions are used to communicate the result of an action taken between the systems using a shared Guid.
    /// </summary>
    public readonly static Guid NotificationSent = new("a7b8c9d0-b4c5-4def-ef01-789012345601");
    public readonly static Guid NotificationError = new("b8c9d0e1-c5d6-4ef0-f012-890123456712");

    public readonly static ImmutableHashSet<Guid> All = [
        RequestInvestiagtion, RequestReply, RequestDataProtectionReview,
        TriggerSection19, TriggerRecordLock, TriggerReplyReceived,
        NotificationSent, NotificationError,
    ];
}
