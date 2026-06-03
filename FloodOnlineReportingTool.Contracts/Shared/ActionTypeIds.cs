using System.Collections.Immutable;

namespace FloodOnlineReportingTool.Contracts.Shared;
public static class ActionTypeIds
{
    public readonly static Guid TriggerFloodSourceArchive = new("076a4d83-4572-48b2-ae67-185c0877693f");
    public readonly static Guid TriggerFloodSourceRestore = new("febe4f8e-ca64-4e83-aabb-99bb15ae25ab");
    public readonly static Guid TriggerFloodSourceRedaction = new("8067409e-7883-4fa9-a7cd-2ccd82ef4074");
    public readonly static Guid TriggerFloodSourceDelete = new("c2d3c27a-a0f6-46f0-b036-9a68b22e55f2");

    public readonly static Guid TriggerFloodReportArchive = new("1a572d25-4dcb-464e-b4d4-b93a74d618aa");
    public readonly static Guid TriggerFloodReportRestore = new("3f9f56fe-0ca5-4851-90ec-8f7a3082c95c");
    public readonly static Guid TriggerFloodReportRedaction = new("ccdcd417-1283-4545-988f-0fc7584bbda0");
    public readonly static Guid TriggerFloodReportDelete = new("7afdfe7c-04a0-43d5-bf9b-abe53e1f2b1c");

    public readonly static Guid TriggerEventArchive = new("e5f6a7b8-92a3-4bcd-cdef-5678901234ef");
    public readonly static Guid TriggerEventRestore = new("d3510bd2-5141-4bcc-8f00-847cf8f9ef19");
    public readonly static Guid TriggerEventDelete = new("123caad9-c1b9-4149-8f9e-3ef33dcd037b");

    public readonly static Guid FurtherDetailRequested = new("a1b2c3d4-5e6f-4789-8abc-1234567890ab");
    public readonly static Guid FurtherDetailProvided = new("df655f85-fef9-4388-ab22-f10fd491657d");

    public readonly static Guid TriggerSection19 = new("d4e5f6a7-8192-4abc-bdef-4567890123de");
    public readonly static Guid TriggerSection19Complete = new("e310c7f5-2c0e-447f-aa27-6cb4c6aea033");

    public readonly static Guid CommentNew = new("24b82488-37ed-4c36-8aae-82479611c3b5");
    public readonly static Guid CommentReply = new("f6a7b8c9-a3b4-4cde-def0-6789012345f0");

    public readonly static ImmutableHashSet<Guid> All = [
        TriggerFloodSourceArchive, TriggerFloodSourceRestore, TriggerFloodSourceRedaction, TriggerFloodSourceDelete,
        TriggerFloodReportArchive, TriggerFloodReportRestore, TriggerFloodReportRedaction, TriggerFloodReportDelete,
        TriggerEventArchive, TriggerEventRestore, TriggerEventDelete,
        FurtherDetailRequested, FurtherDetailProvided,
        TriggerSection19, TriggerSection19Complete,
        CommentNew, CommentReply,
    ];
}
