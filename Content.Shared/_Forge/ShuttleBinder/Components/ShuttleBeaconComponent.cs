using Robust.Shared.GameStates;

namespace Content.Shared._Forge.ShuttleBinder.Components;

[RegisterComponent, NetworkedComponent]
public sealed partial class ShuttleBeaconComponent : Component
{
    [DataField("beaconId")]
    public string BeaconId = "default";
    
    [ViewVariables]
    public bool Active = true;
}
