using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content.Shared._CCM14.Miners.Events;

[Serializable, NetSerializable]
public sealed partial class MinerExtractionDoAfterEvent : SimpleDoAfterEvent
{
}
