using Robust.Shared.Serialization;

namespace Content.Shared._Forge.BinderConsole.Events;

[Serializable, NetSerializable]
public sealed class ShuttleBinderBindMessage : BoundUserInterfaceMessage
{
}

[Serializable, NetSerializable]
public sealed class ShuttleBinderUnbindMessage : BoundUserInterfaceMessage
{
}

[Serializable, NetSerializable]
public sealed class ShuttleBinderEjectMessage : BoundUserInterfaceMessage
{
}
