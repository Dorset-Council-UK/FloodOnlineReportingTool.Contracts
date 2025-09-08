namespace FloodOnlineReportingTool.Contracts.Shared;

/// <summary>
/// The flood source IDs.
/// Helps ensure consistency and allows easier comparison.
/// </summary>
public static class FloodSourceIds
{
    // Primary cause Id's
    public readonly static Guid PrimaryCauseRiver = new("018fe08b-a800-7cb2-aa1b-f39aefc48152");
    public readonly static Guid PrimaryCauseStreamOrWatercourse = new("018fe08c-9260-77ad-9e3a-418bb047ff5d");
    public readonly static Guid LakeOrReservoir = new("018fe08d-7cc0-70ce-89e3-78360019c9b7");
    public readonly static Guid PrimaryCauseTheSea = new("018fe08e-6720-70ea-9a72-bf9aa0de312b");
    public readonly static Guid PrimaryCauseDitchesAndDrainageChannels = new("018fe08f-5180-744d-ab20-b58bf6d04fbb");
    public readonly static Guid WaterRisingOutOfTheGround = new("018fe090-3be0-7d28-b73d-ba671aa61208");
    public readonly static Guid FoulDrainageSewerage = new("018fe091-2640-7a8c-ab1e-5c762268a1d7");
    public readonly static Guid SurfaceWaterDrainage = new("018fe092-10a0-7858-8987-1f84395524b7");
    public readonly static Guid BlockedRoadDrainage = new("018fe092-fb00-7a34-a8c9-bdac73a1acaa");
    public readonly static Guid BridgeOrCulvert = new("018fe093-e560-74dc-ac18-f4949190dce3");
    public readonly static Guid WavesCausedByVehicles = new("018fe094-cfc0-7156-99f5-2fc20e9e19ea");
    public readonly static Guid RainwaterFlowingOverTheGround = new("018fe095-ba20-7234-b73b-ff8e340dd9fc");
    public readonly static Guid PrimaryCauseNotSure = new("018fe096-a480-70d8-91f4-03504bcf926c");

    // Secondary cause Id's
    public readonly static Guid RunoffFromRoad = new("018fe0c2-9680-78b5-a5fd-ca2bb2ddd0e3");
    public readonly static Guid RunoffFromPrivateRoad = new("018fe0c3-80e0-7a22-a8d4-36ad1e5dd626");
    public readonly static Guid RunoffFromTrackOrPath = new("018fe0c4-6b40-7441-afbb-381e233f4906");
    public readonly static Guid RunoffFromAgriculturalLand = new("018fe0c5-55a0-7991-8ee8-1df41519d18e");
    public readonly static Guid RunoffFromOtherProperty = new("018fe0c6-4000-7e95-84d4-1ad96cf4f598");
    public readonly static Guid SecondaryCauseNotSure = new("018fe0c7-2a60-7983-b7c3-afa68072aa5f");
}
