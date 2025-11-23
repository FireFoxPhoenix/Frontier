using Content.Shared._Forge.ShuttleBinder.Components;

namespace Content.Server._Forge.ShuttleBinder;

public sealed class ShuttleBeaconSystem : EntitySystem
{
    public override void Initialize()
    {
        SubscribeLocalEvent<ShuttleBeaconComponent, ComponentStartup>(OnBeaconStartup);
        SubscribeLocalEvent<ShuttleBeaconComponent, ComponentShutdown>(OnBeaconShutdown);
    }

    private void OnBeaconStartup(EntityUid uid, ShuttleBeaconComponent component, ComponentStartup args)
    {
        component.Active = true;
        Dirty(uid, component);
    }

    private void OnBeaconShutdown(EntityUid uid, ShuttleBeaconComponent component, ComponentShutdown args)
    {
        component.Active = false;
    }

    public EntityUid? FindBeaconById(string beaconId)
    {
        var query = EntityQueryEnumerator<ShuttleBeaconComponent>();
        while (query.MoveNext(out var uid, out var beacon))
        {
            if (beacon.Active && beacon.BeaconId == beaconId)
                return uid;
        }
        return null;
    }
}
