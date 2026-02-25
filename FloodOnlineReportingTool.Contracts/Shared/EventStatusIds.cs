using System.Collections.Immutable;

namespace FloodOnlineReportingTool.Contracts.Shared;

public static class EventStatusIds
{
    // This class contains statuses related to flood events (area).

    /// <summary>
    /// Flood event phase Ids
    /// </summary>
    public readonly static Guid PreparePhase = new("018feb46-3d00-72a8-a3e1-056e99014150");
    public readonly static Guid ResponsePhase = new("018feb47-2760-7161-af3d-6c1036e802ed");
    public readonly static Guid RecoveryPhase = new("018feb48-11c0-7fd1-a032-e87cae11748c");
    public readonly static Guid AnalysePhase = new("018feb48-fc20-7d06-b7cd-b4440af84719");

    /// <summary>
    /// Flood event status Ids
    /// This is used to track the overview of the impact of a flood event.
    /// We capture whether the event is a prediction or past event and whether properties were flooded. 
    /// This allows you to filter events, for example only events where properties were flooded internally
    /// vs events where it was only blocked access.
    /// </summary>
    public readonly static Guid FloodExpectedNoFlood = new("018feb7d-2b80-7da6-bd00-dd2c83fa2a2e");
    public readonly static Guid FloodExpectedHelpGiven = new("018feb7e-15e0-7a9d-ac21-bc1cc63e081c");
    public readonly static Guid PropertiesAffected = new("018feb7f-0040-7d3f-ae3c-796c50850cbe");
    public readonly static Guid PropertiesAffectedHelpGiven = new("018feb7f-eaa0-7507-af59-497aac53467d");
    public readonly static Guid BuildingsFlooded = new("018feb80-d500-7aa7-b155-b6c3218ff2cc");
    public readonly static Guid BuildingsFloodedHelpGiven = new("018feb81-bf60-788d-86c9-ec5f1cc1871c");
    public readonly static Guid NoFloodingOccurred = new("018feb82-a9c0-7d33-bbf1-64422e309748");

    public readonly static ImmutableHashSet<Guid> All = [
        PreparePhase, ResponsePhase, RecoveryPhase, AnalysePhase,
        FloodExpectedNoFlood, FloodExpectedHelpGiven, PropertiesAffected, PropertiesAffectedHelpGiven, BuildingsFlooded, BuildingsFloodedHelpGiven, NoFloodingOccurred
    ];
}
