﻿namespace MintingUi.Client.Features.Counter.Components
{
  using System.Threading.Tasks;
  using MintingUi.Client.Features.Base.Components;
  using static MintingUi.Client.Features.Counter.CounterState;

  public class CounterBase : BaseComponent
  {
    protected async Task ButtonClick() =>
      _ = await Mediator.Send(new IncrementCounterAction { Amount = 5 });
  }
}