using System.Collections.Immutable;

namespace FloodOnlineReportingTool.Contracts.Shared;

public static class Section19StatusIds
{
    /// <summary>
    /// Status Ids describing whether a Section 19 is in progress.
    /// </summary>
    public readonly static Guid NoSection19 = new("018febeb-0880-7532-b583-3d9502dffd7b");
    public readonly static Guid Section19Required = new("018febeb-f2e0-7d1d-89a3-b76b1fe98343");
    public readonly static Guid Section19InProgress = new("018febec-dd40-7863-b45c-e7b9546f588c");
    public readonly static Guid Section19Included = new("018febed-c7a0-7994-8c44-4623142fdfb1");

    public readonly static ImmutableHashSet<Guid> All = [
        NoSection19, Section19Required, Section19InProgress, Section19Included
    ];
}
