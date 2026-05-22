using Robust.Shared.GameStates;

namespace Content.Shared._CCM14.Xenonids.TailWhirlwind;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(TailWhirlwindSystem))]
public sealed partial class TailWhirlwindingComponent : Component
{
    [DataField, AutoNetworkedField]
    public Angle LastAngle;
}
