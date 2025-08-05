namespace Content.Server.Kitchen.Components;

/// <summary>
///     Applies to items that are capable of butchering entities, or
///     are otherwise sharp for some purpose.
/// </summary>
[RegisterComponent]
public sealed partial class SharpComponent : Component
{
    // TODO just make this a tool type.
    public HashSet<EntityUid> Butchering = new();

    [DataField("butcherDelayModifier")]
    public float ButcherDelayModifier = 1.0f;

    [DataField]
    public bool HadSurgeryTool; // forge-Change

    [DataField]
    public bool HadScalpel; // Forge-Change

    [DataField]
    public bool HadBoneSaw; // Forge-Change
}
