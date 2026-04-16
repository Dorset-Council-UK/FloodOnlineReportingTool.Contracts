using System.Collections.Immutable;

namespace FloodOnlineReportingTool.Contracts.Shared;

public static class RecordStatusIds
{
    // This class contains statuses related to flood reports (point).
    // Also includes validation and data protection statuses which are used across the system but are related to the status of a record.

    /// <summary>
    /// Flood report status Ids
    /// </summary>
    public readonly static Guid MarkedForDeletion = new("018feb0f-4e80-767d-8262-36a1217ae690"); // The record is marked for deletion
    /// <remarks>In original FORT this was Unread</remarks>
    public readonly static Guid New = new("018feb10-38e0-7f30-a546-37ce71f243ae"); // This record is new and has not been viewed yet
    public readonly static Guid Viewed = new("018feb11-2340-7449-9a20-83e2043a6817"); // This record has been viewed but no action has been taken yet
    /// <remarks>In original FORT this was Programmed</remarks>
    public readonly static Guid ActionNeeded = new("018feb12-0da0-749b-a59a-cb3ed128d982"); // Action is needed on this record and needs to be reviewed
    /// <remarks>In original FORT this was Investigated</remarks>
    public readonly static Guid ActionCompleted = new("018feb12-f800-75e0-ab95-e780864249c8"); // Action has been completed on this record
    public readonly static Guid DuplicateDetected = new("018feb13-0b00-7c8e-9a1c-1d9b2f8c3c44"); // This record has been identified as having possible duplicate source records and needs to be reviewed
    /// <remarks>In original FORT this was Invalid</remarks>
    public readonly static Guid Error = new("018feb13-e260-7c11-9106-c179ba7c8ce4"); // This record has an error and needs to be reviewed

    /// <summary>
    /// Validation Ids
    /// </summary>
    public readonly static Guid Unconfirmed = new("018febb4-1a00-7aee-9b88-1d748f18c059");
    public readonly static Guid Validated = new("018febb5-0460-790e-bd7f-9684e1aa6ce9");

    /// <summary>
    /// Data Protection Ids
    /// </summary>
    public readonly static Guid NotAcknowledged = new("018fec21-f700-745d-a90f-9f0204c1e2d6");
    public readonly static Guid Agreed = new("018fec22-e160-7cda-92ef-1e9b92d7dd1c");

    public readonly static ImmutableHashSet<Guid> All = [
        MarkedForDeletion, New, Viewed, ActionNeeded, ActionCompleted, DuplicateDetected, Error,
        Unconfirmed, Validated,
        NotAcknowledged, Agreed
    ];
}
