using Robust.Shared.Serialization;

namespace Content.Shared._CCM14.Vehicle.Fabricator;

[Serializable]
[NetSerializable]
public enum VehicleFabricatorVisuals
{
    State
}

[Serializable]
[NetSerializable]
public enum VehicleFabricatorState
{
    Idle,
    Fabricating
}