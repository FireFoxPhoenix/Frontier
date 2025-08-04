using Content.Shared.Body.Components;
using Robust.Shared.Serialization;

namespace Content.Shared.Body.Part
{
    /// <summary>
    ///     Defines the type of a <see cref="BodyComponent"/>.
    /// </summary>
    [Serializable, NetSerializable]
    public enum BodyPartType
    {
        Other = 0,
        // Forge-Change start
        Chest,
        Groin,
        Torso, // не забыть удалить
        // Forge-Change end
        Head,
        Arm,
        Hand,
        Leg,
        Foot,
        Tail
    }
}
