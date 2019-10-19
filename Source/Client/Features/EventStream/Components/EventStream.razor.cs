namespace MintingUi.Client.Features.EventStream.Components
{
  using System.Collections.Generic;
  using MintingUi.Client.Features.Base.Components;

  public class EventStreamBase : BaseComponent
  {
    public IReadOnlyList<string> Events => EventStreamState.Events;
  }
}
