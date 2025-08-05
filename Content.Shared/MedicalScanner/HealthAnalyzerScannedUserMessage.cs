using Robust.Shared.Serialization;
using Content.Shared._Shitmed.Medical.Surgery.Wounds; // Forge Change
using Content.Shared._Shitmed.Targeting; // Forge Change

namespace Content.Shared.MedicalScanner;

/// <summary>
///     On interacting with an entity retrieves the entity UID for use with getting the current damage of the mob.
/// </summary>
[Serializable, NetSerializable]
public sealed class HealthAnalyzerScannedUserMessage : BoundUserInterfaceMessage
{
    public readonly NetEntity? TargetEntity;
    public float Temperature;
    public float BloodLevel;
    public bool? ScanMode;
    public bool? Bleeding;
    public bool? Unrevivable;
    public bool? Unclonable; // Frontier
    public Dictionary<TargetBodyPart, WoundableSeverity>? Body; // Forge Change
    public NetEntity? Part; // Forge Change

    public HealthAnalyzerScannedUserMessage(NetEntity? targetEntity, float temperature, float bloodLevel, bool? scanMode, bool? bleeding, bool? unrevivable, bool? unclonable, Dictionary<TargetBodyPart, WoundableSeverity>? body, NetEntity? part = null) // Frontier: added unclonable, body, part
    {
        TargetEntity = targetEntity;
        Temperature = temperature;
        BloodLevel = bloodLevel;
        ScanMode = scanMode;
        Bleeding = bleeding;
        Unrevivable = unrevivable;
        Unclonable = unclonable; // Frontier
        Body = body; // Forge Change
        Part = part; // Forge Change
    }
}

// Forge Change Start
[Serializable, NetSerializable]
public sealed class HealthAnalyzerPartMessage(NetEntity? owner, TargetBodyPart? bodyPart) : BoundUserInterfaceMessage
{
    public readonly NetEntity? Owner = owner;
    public readonly TargetBodyPart? BodyPart = bodyPart;

}
// Forge Change End
