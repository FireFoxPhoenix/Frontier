namespace Content.Shared.Rejuvenate;

public sealed class RejuvenateEvent(bool uncuff = true, bool resetActions = true) : EntityEventArgs // Forge edit
{
    // Forge-Change start
    public bool Uncuff = uncuff;

    public bool ResetActions = resetActions;
    // Forge-Change end
}
