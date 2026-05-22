using Robust.Shared.Containers;

namespace Content.Shared._CCM14.Storage;

[ByRefEvent]
public record struct EntityStorageIntoContainerAttemptEvent(BaseContainer Container, bool Cancelled = false);
