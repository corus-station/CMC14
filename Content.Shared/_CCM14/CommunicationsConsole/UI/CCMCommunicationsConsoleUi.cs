using Robust.Shared.Serialization;

namespace Content.Shared._CCM14.CommunicationsConsole.UI;

[Serializable, NetSerializable]
public sealed class CCMCommunicationsConsoleBuiState : BoundUserInterfaceState;

[Serializable, NetSerializable]
public enum CCMCommunicationsConsoleUi
{
    Key,
}
