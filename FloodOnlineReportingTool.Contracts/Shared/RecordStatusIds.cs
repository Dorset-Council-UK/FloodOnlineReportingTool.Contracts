using System.Collections.Immutable;

namespace FloodOnlineReportingTool.Contracts.Shared;

public static class RecordStatusIds
{
    // In original FORT flood reports were known as POINT and events were known as AREA records

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
    /// <remarks>In original FORT this was Invalid</remarks>
    public readonly static Guid Error = new("018feb13-e260-7c11-9106-c179ba7c8ce4"); // This record has an error and needs to be reviewed

    /// <summary>
    /// Flood event phase Ids
    /// </summary>
    public readonly static Guid PreparePhase = new("018feb46-3d00-72a8-a3e1-056e99014150");
    public readonly static Guid ResponsePhase = new("018feb47-2760-7161-af3d-6c1036e802ed");
    public readonly static Guid RecoveryPhase = new("018feb48-11c0-7fd1-a032-e87cae11748c");
    public readonly static Guid AnalysePhase = new("018feb48-fc20-7d06-b7cd-b4440af84719");

    /// <summary>
    /// Flood event status Ids
    /// This is used to track the overview of the impact of a flood event where events that flooded properties are of most interest.
    /// </summary>
    public readonly static Guid FloodExpectedNoFlood = new("018feb7d-2b80-7da6-bd00-dd2c83fa2a2e");
    public readonly static Guid FloodExpectedHelpGiven = new("018feb7e-15e0-7a9d-ac21-bc1cc63e081c");
    public readonly static Guid PropertiesAffected = new("018feb7f-0040-7d3f-ae3c-796c50850cbe");
    public readonly static Guid PropertiesAffectedHelpGiven = new("018feb7f-eaa0-7507-af59-497aac53467d");
    public readonly static Guid BuildingsFlooded = new("018feb80-d500-7aa7-b155-b6c3218ff2cc");
    public readonly static Guid BuildingsFloodedHelpGiven = new("018feb81-bf60-788d-86c9-ec5f1cc1871c");
    public readonly static Guid NoFloodingOccurred = new("018feb82-a9c0-7d33-bbf1-64422e309748");

    /// <summary>
    /// Validation Ids
    /// </summary>
    public readonly static Guid Unconfirmed = new("018febb4-1a00-7aee-9b88-1d748f18c059");
    public readonly static Guid Validated = new("018febb5-0460-790e-bd7f-9684e1aa6ce9");

    /// <summary>
    /// Section 19 Ids
    /// </summary>
    public readonly static Guid NoSection19 = new("018febeb-0880-7532-b583-3d9502dffd7b");
    public readonly static Guid Section19Required = new("018febeb-f2e0-7d1d-89a3-b76b1fe98343");
    public readonly static Guid Section19InProgress = new("018febec-dd40-7863-b45c-e7b9546f588c");
    public readonly static Guid Section19Included = new("018febed-c7a0-7994-8c44-4623142fdfb1");

    /// <summary>
    /// Data Protection Ids
    /// </summary>
    public readonly static Guid NotAcknowledged = new("018fec21-f700-745d-a90f-9f0204c1e2d6");
    public readonly static Guid Agreed = new("018fec22-e160-7cda-92ef-1e9b92d7dd1c");

    public readonly static ImmutableHashSet<Guid> All = [
        MarkedForDeletion, New, Viewed, ActionNeeded, ActionCompleted, Error,
        PreparePhase, ResponsePhase, RecoveryPhase, AnalysePhase,
        FloodExpectedNoFlood, FloodExpectedHelpGiven, PropertiesAffected, PropertiesAffectedHelpGiven, BuildingsFlooded, BuildingsFloodedHelpGiven, NoFloodingOccurred,
        Unconfirmed, Validated,
        NoSection19, Section19Required, Section19InProgress, Section19Included,
        NotAcknowledged, Agreed
    ];
}
