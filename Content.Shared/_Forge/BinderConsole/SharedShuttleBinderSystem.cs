using Content.Shared.Containers.ItemSlots;
using JetBrains.Annotations;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared._Forge.BinderConsole;

[NetSerializable, Serializable]
public enum ShuttleBinderUiKey : byte
{
    Key
}

public abstract class SharedShuttleBinderSystem : EntitySystem
{
    [Dependency] private readonly ItemSlotsSystem _itemSlotsSystem = default!;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<ShuttleBinderComponent, ComponentInit>(OnComponentInit);
        SubscribeLocalEvent<ShuttleBinderComponent, ComponentRemove>(OnComponentRemove);
    }

    private void OnComponentInit(EntityUid uid, ShuttleBinderComponent component, ComponentInit args)
    {
        _itemSlotsSystem.AddItemSlot(uid, ShuttleBinderComponent.TargetMapSlotId, component.TargetMapSlot);
    }

    private void OnComponentRemove(EntityUid uid, ShuttleBinderComponent component, ComponentRemove args)
    {
        _itemSlotsSystem.RemoveItemSlot(uid, component.TargetMapSlot);
    }
}
