using Content.Shared.IgnitionSource.Components;
using Content.Shared.Smoking;

namespace Content.Shared.IgnitionSource.Systems;

public abstract class SharedMatchstickSystem : EntitySystem
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
