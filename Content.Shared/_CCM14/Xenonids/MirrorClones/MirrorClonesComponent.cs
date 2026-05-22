using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._CCM14.Xenonids.MirrorClones;

[RegisterComponent]
[NetworkedComponent, AutoGenerateComponentState]
public sealed partial class MirrorClonesComponent : Component
{
    [DataField, AutoNetworkedField] public EntProtoId ClonePrototype = "CCMXenoHunterMirrorClone";
}
