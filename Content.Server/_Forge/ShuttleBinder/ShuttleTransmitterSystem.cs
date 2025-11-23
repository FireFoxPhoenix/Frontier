using Content.Shared._Forge.ShuttleBinder.Components;
using Content.Shared.Shuttles.Components;
using Content.Shared.Interaction.Events;
using Content.Shared.Popups;

namespace Content.Server._Forge.ShuttleBinder;

public sealed class ShuttleTransmitterSystem : EntitySystem
{
    [Dependency] private readonly SharedPopupSystem _popup = default!;

    public override void Initialize()
    {
        SubscribeLocalEvent<ShuttleTransmitterComponent, ComponentStartup>(OnTransmitterStartup);
        SubscribeLocalEvent<ShuttleTransmitterComponent, ComponentShutdown>(OnTransmitterShutdown);
        SubscribeLocalEvent<ShuttleTransmitterComponent, ActivateInWorldEvent>(OnTransmitterActivate);
    }

    private void OnTransmitterStartup(EntityUid uid, ShuttleTransmitterComponent component, ComponentStartup args)
    {
        UpdateShuttleTarget(uid, component.LinkedBeacon);
    }

    private void OnTransmitterShutdown(EntityUid uid, ShuttleTransmitterComponent component, ComponentShutdown args)
    {
        UpdateShuttleTarget(uid, null);
    }

    private void OnTransmitterActivate(EntityUid uid, ShuttleTransmitterComponent component, ActivateInWorldEvent args)
    {
        if (args.Handled)
            return;

        if (component.LinkedBeacon != null)
        {
            UnlinkFromBeacon(uid, component);
            _popup.PopupEntity("Transmitter unlinked from beacon");
        }
        else
        {
            _popup.PopupEntity("Transmitter is not linked to any beacon. Use it on a beacon to link.");
        }
        args.Handled = true;
    }

    public void LinkToBeacon(EntityUid transmitterUid, EntityUid beaconUid, ShuttleTransmitterComponent? component = null)
    {
        if (!Resolve(transmitterUid, ref component))
            return;

        component.LinkedBeacon = beaconUid;
        UpdateShuttleTarget(transmitterUid, beaconUid);
        Dirty(transmitterUid, component);
    }

    public void UnlinkFromBeacon(EntityUid transmitterUid, ShuttleTransmitterComponent? component = null)
    {
        if (!Resolve(transmitterUid, ref component))
            return;

        component.LinkedBeacon = null;
        UpdateShuttleTarget(transmitterUid, null);
        Dirty(transmitterUid, component);
    }

    private void UpdateShuttleTarget(EntityUid transmitterUid, EntityUid? beaconUid)
    {
        if (!TryComp<TransformComponent>(transmitterUid, out var xform) || xform.GridUid == null)
            return;

        var shuttleUid = xform.GridUid.Value;
        
        if (!TryComp<ShuttleComponent>(shuttleUid, out var shuttle))
            return;

        if (beaconUid != null)
        {
            var stationUid = FindStationForBeacon(beaconUid.Value);
            if (stationUid != null)
            {
                shuttle.TargetPOI = stationUid;
            }
            else
            {
                shuttle.TargetPOI = null;
            }
        }
        else
        {
            shuttle.TargetPOI = null;
        }
        Dirty(shuttleUid, shuttle);
    }

    private EntityUid? FindStationForBeacon(EntityUid beaconUid)
    {
        if (!TryComp<TransformComponent>(beaconUid, out var beaconXform) || beaconXform.GridUid == null)
            return null;

        var gridUid = beaconXform.GridUid.Value;
        
        //if (TryComp<BecomesStationComponent>(gridUid, out _))
        //    return gridUid;
        return gridUid;

        //return null;
    }
}
