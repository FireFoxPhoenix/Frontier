using Robust.Shared.GameStates;
using Robust.Shared.Audio;
using Content.Shared.Containers.ItemSlots;

namespace Content.Shared._Forge.BinderConsole.Components;

[RegisterComponent, NetworkedComponent, Access(typeof(SharedShuttleBinderSystem))]
public sealed partial class ShuttleBinderComponent : Component
{
    public static string TargetMapSlotId = "ShuttleBinder-targetMap";

    [DataField]
    public ItemSlot TargetMapSlot = new();

    [DataField]
    public SoundSpecifier ErrorSound =
        new SoundPathSpecifier("/Audio/Effects/Cargo/buzz_sigh.ogg");

    [DataField]
    public SoundSpecifier ConfirmSound =
        new SoundPathSpecifier("/Audio/Effects/Cargo/ping.ogg");

    /// <summary>
    /// The time at which the console will be able to play the deny sound.
    /// </summary>
    [DataField]
    public TimeSpan NextDenySoundTime = TimeSpan.Zero;

    /// <summary>
    /// The minimum time between playing the deny sound.
    /// </summary>
    [DataField]
    public TimeSpan DenySoundDelay = TimeSpan.FromSeconds(2);
}
