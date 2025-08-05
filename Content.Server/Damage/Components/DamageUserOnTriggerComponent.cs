using Content.Shared.Damage;
using Content.Shared._Shitmed.Targeting; // Forge-Change

namespace Content.Server.Damage.Components;

[RegisterComponent]
public sealed partial class DamageUserOnTriggerComponent : Component
{
    [DataField("ignoreResistances")] public bool IgnoreResistances;

    [DataField("damage", required: true)]
    public DamageSpecifier Damage = default!;

    [DataField]
    public TargetBodyPart? TargetPart = TargetBodyPart.Feet; // Forge-Change
}
