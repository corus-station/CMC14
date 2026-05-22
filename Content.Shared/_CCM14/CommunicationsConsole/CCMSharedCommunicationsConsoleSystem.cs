using Content.Shared._CCM14.CommunicationsConsole.Components;
using Content.Shared._CCM14.CommunicationsConsole.UI;

namespace Content.Shared._CCM14.CommunicationsConsole;

public abstract class CCMSharedCommunicationsConsoleSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<CCMCommunicationsConsoleComponent, CCMCommunicationsConsoleERTCallBuiMessage>(OnRunMessage);
    }

    protected virtual void OnRunMessage(Entity<CCMCommunicationsConsoleComponent> entity, ref CCMCommunicationsConsoleERTCallBuiMessage args)
    {
    }
}
// thanks to _gadmin1 (discord) for the provided code
