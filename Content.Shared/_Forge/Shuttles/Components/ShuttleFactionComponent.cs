using Robust.Shared.GameStates;

namespace Content.Shared.Shuttles.Components
{
    [RegisterComponent, NetworkedComponent]
    public sealed partial class ShuttleFactionComponent : Component
    {
        [DataField("faction")]
        public string Faction = string.Empty;
    }
}
