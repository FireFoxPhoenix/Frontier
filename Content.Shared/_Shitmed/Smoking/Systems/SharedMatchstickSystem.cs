using Content.Shared.IgnitionSource.Components;

namespace Content.Shared.Smoking.Systems;

public abstract class MatchstickSystem : EntitySystem
{
    public virtual bool SetState(Entity<MatchstickComponent> ent, SmokableState state)
    {
        if (ent.Comp.State == state)
            return false;

        ent.Comp.State = state;
        Dirty(ent);
        return true;
    }
}
